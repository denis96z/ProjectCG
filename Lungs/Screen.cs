using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lungs
{
    class Screen
    {
        public static readonly Color DEFAULT_BACK_COLOR = Color.Black;

        private Graphics _Canvas;
        private ZBuffer _ZBuffer;
        private int _Width, _Height;
        private Color _BackColor;

        public Screen(Graphics g, int width, int height)
        {
            _Canvas = g;

            _Width = width;
            _Height = height;

            _HalfWidth = _Width / 2;
            _HalfHeight = _Height / 2;

            _BackColor = DEFAULT_BACK_COLOR;

            _ZBuffer = new ZBuffer(width, height);
        }

        public Color BackColor
        {
            get { return _BackColor; }
            set { _BackColor = value; }
        }

        public void Clear()
        {
            _Canvas.Clear(_BackColor);
            _ZBuffer.Clear();
        }

        public void DrawScene(Scene scene)
        {
            Clear();

            Vertex lv = new Vertex(scene.Light.Position.X,
                scene.Light.Position.Y, scene.Light.Position.Z);
            lv.Color = Color.White;

            DrawVertex(lv);
            
            for (int i = 0; i < scene.Model.TrianglesCount; i++)
            {
                Triangle3D t = scene.Model[i];
                DrawTriangle(t, scene.Light);
            }
        }

        public void DrawTriangle(Triangle3D t, Light light)
        {
            Triangle3DRasterizer r = new Triangle3DRasterizer(t, light);
            Triangle3DLine[] lines = r.Execute();

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Count; j++)
                {
                    DrawVertex(lines[i][j]);
                }
            }
        }

        private int _HalfWidth, _HalfHeight;

        public void DrawVertex(Vertex v)
        {
            int x = Maths.Round(v.Position.X) + _HalfWidth;
            int y = Maths.Round(v.Position.Y) + _HalfHeight;

            if (x < 0 || x >= _Width)
            {
                return;
            }
            if (y < 0 || y >= _Height)
            {
                return;
            }

            double z = v.Position.Z;

            if (z < _ZBuffer[x, y])
            {
                _Canvas.FillRectangle(new SolidBrush(v.Color), x, y, 1, 1);
                _ZBuffer[x, y] = z;
            }
        }
    }

    class Triangle3DLine
    {
        private Vertex[] _Vertexes;

        private int _Count;
        private int _FirstIndex;
        private int _LastIndex;

        public Triangle3DLine(Vertex v1, Vertex v2)
        {
            int x1 = Maths.Round(v1.Position.X);
            int x2 = Maths.Round(v2.Position.X);

            _Count = Math.Abs(x2 - x1) + 1;

            _FirstIndex = 0;
            _LastIndex = _Count - 1;

            _Vertexes = new Vertex[_Count];

            if (x2 > x1)
            {
                _Vertexes[_FirstIndex] = v1;
                _Vertexes[_LastIndex] = v2;
            }
            else
            {
                _Vertexes[_FirstIndex] = v2;
                _Vertexes[_LastIndex] = v1;
            }
        }

        public Vertex V1
        {
            get { return _Vertexes[_FirstIndex]; }
        }

        public Vertex V2
        {
            get { return _Vertexes[_LastIndex]; }
        }

        public Vertex this[int index]
        {
            get { return _Vertexes[index]; }
            set { _Vertexes[index] = value; }
        }

        public int Count
        {
            get { return _Count; }
        }
    }


    class Triangle3DRasterizer
    {
        private Triangle3D _Triangle;
        private Light _Light;

        private int _X1, _Y1;
        private int _X2, _Y2;
        private int _X3, _Y3;

        private int yMin, yMax;

        private Triangle3DLine[] _Lines;

        public Triangle3DRasterizer(Triangle3D triangle, Light light)
        {
            _Triangle = triangle;
            _Light = light;

            _X1 = Maths.Round(triangle.V1.Position.X);
            _Y1 = Maths.Round(triangle.V1.Position.Y);

            _X2 = Maths.Round(triangle.V2.Position.X);
            _Y2 = Maths.Round(triangle.V2.Position.Y);

            _X3 = Maths.Round(triangle.V3.Position.X);
            _Y3 = Maths.Round(triangle.V3.Position.Y);

            yMin = Maths.Min(_Y1, _Y2, _Y3);
            yMax = Maths.Max(_Y1, _Y2, _Y3);

            _Lines = new Triangle3DLine[yMax - yMin + 1];
        }

        public Triangle3DLine[] Execute()
        {
            RasterizeEdges();
            RasterizeLines();
            FindColors();

            return _Lines;
        }

        private void RasterizeEdges()
        {
            List<Vertex>[] edges = new List<Vertex>[yMax - yMin + 1];
            for (int i = 0; i < edges.Length; i++)
            {
                edges[i] = new List<Vertex>();
            }

            RasterizeExtremums(ref edges);

            for (int i = Triangle3D.V1_INDEX; i <= Triangle3D.V3_INDEX; i++)
            {
                int y1 = Maths.Round(_Triangle[i].Position.Y);
                int y2 = Maths.Round(_Triangle[i + 1].Position.Y);

                if (y1 == y2)
                {
                    continue;
                }

                RasterizeEdge(ref edges, _Triangle[i], _Triangle[i + 1]);
            }

            for (int i = 0; i < edges.Length; i++)
            {
                _Lines[i] = new Triangle3DLine(new Vertex(edges[i][0]), new Vertex(edges[i][1]));
            }

            for (int i = 0; i < edges.Length; i++)
            {
                edges[i].Clear();
            }
        }

        private void RasterizeLines()
        {
            for (int i = 0; i < _Lines.Length; i++)
            {
                if (_Lines[i].Count > 1)
                {
                    RasterizeLine(_Lines[i]);
                }
            }
        }

        private void RasterizeExtremums(ref List<Vertex>[] edges)
        {
            // Все ребра в горизонтальной плоскости.
            if (_Y1 == _Y2 && _Y2 == _Y3)
            {
                int xMin = Maths.Min(_X1, _X2, _X3);
                int xMax = Maths.Max(_X1, _X2, _X3);

                if (_X1 == xMin)
                {
                    edges[0].Add(_Triangle.V1);
                }
                else if (_X2 == xMin)
                {
                    edges[0].Add(_Triangle.V2);
                }
                else if (_X3 == xMin)
                {
                    edges[0].Add(_Triangle.V3);
                }


                if (_X1 == xMax)
                {
                    edges[0].Add(_Triangle.V1);
                }
                else if (_X2 == xMax)
                {
                    edges[0].Add(_Triangle.V2);
                }
                else if (_X3 == xMax)
                {
                    edges[0].Add(_Triangle.V3);
                }
            }
            // Первое ребро в горизонтальной плоскости.
            else if (_Y1 == _Y2)
            {
                if (_Y1 == yMin)
                {
                    edges[0].Add(_Triangle.V1);
                    edges[0].Add(_Triangle.V2);
                    edges[edges.Length - 1].Add(_Triangle.V3);
                    edges[edges.Length - 1].Add(_Triangle.V3);
                }
                else
                {
                    edges[0].Add(_Triangle.V3);
                    edges[0].Add(_Triangle.V3);
                    edges[edges.Length - 1].Add(_Triangle.V1);
                    edges[edges.Length - 1].Add(_Triangle.V2);
                }
            }
            // Второе ребро в горизонтальной плоскости.
            else if (_Y1 == _Y3)
            {
                if (_Y1 == yMin)
                {
                    edges[0].Add(_Triangle.V1);
                    edges[0].Add(_Triangle.V3);
                    edges[edges.Length - 1].Add(_Triangle.V2);
                    edges[edges.Length - 1].Add(_Triangle.V2);
                }
                else
                {
                    edges[0].Add(_Triangle.V2);
                    edges[0].Add(_Triangle.V2);
                    edges[edges.Length - 1].Add(_Triangle.V1);
                    edges[edges.Length - 1].Add(_Triangle.V3);
                }
            }
            // Третье ребро в горизонтальной плоскости.
            else if (_Y2 == _Y3)
            {
                if (_Y2 == yMin)
                {
                    edges[0].Add(_Triangle.V2);
                    edges[0].Add(_Triangle.V3);
                    edges[edges.Length - 1].Add(_Triangle.V1);
                    edges[edges.Length - 1].Add(_Triangle.V1);
                }
                else
                {
                    edges[0].Add(_Triangle.V1);
                    edges[0].Add(_Triangle.V1);
                    edges[edges.Length - 1].Add(_Triangle.V2);
                    edges[edges.Length - 1].Add(_Triangle.V3);
                }
            }
            // Ни одно из ребер не горизонтально.
            else
            {
                if (_Y1 == yMin && _Y2 == yMax)
                {
                    edges[0].Add(_Triangle.V1);
                    edges[0].Add(_Triangle.V1);
                    edges[edges.Length - 1].Add(_Triangle.V2);
                    edges[edges.Length - 1].Add(_Triangle.V2);
                    edges[_Y3 - yMin].Add(_Triangle.V3);
                }
                else if (_Y1 == yMin && _Y3 == yMax)
                {
                    edges[0].Add(_Triangle.V1);
                    edges[0].Add(_Triangle.V1);
                    edges[edges.Length - 1].Add(_Triangle.V3);
                    edges[edges.Length - 1].Add(_Triangle.V3);
                    edges[_Y2 - yMin].Add(_Triangle.V2);
                }
                else if (_Y2 == yMin && _Y1 == yMax)
                {
                    edges[0].Add(_Triangle.V2);
                    edges[0].Add(_Triangle.V2);
                    edges[edges.Length - 1].Add(_Triangle.V1);
                    edges[edges.Length - 1].Add(_Triangle.V1);
                    edges[_Y3 - yMin].Add(_Triangle.V3);
                }
                else if (_Y2 == yMin && _Y3 == yMax)
                {
                    edges[0].Add(_Triangle.V2);
                    edges[0].Add(_Triangle.V2);
                    edges[edges.Length - 1].Add(_Triangle.V3);
                    edges[edges.Length - 1].Add(_Triangle.V3);
                    edges[_Y1 - yMin].Add(_Triangle.V1);
                }
                else if (_Y3 == yMin && _Y1 == yMax)
                {
                    edges[0].Add(_Triangle.V3);
                    edges[0].Add(_Triangle.V3);
                    edges[edges.Length - 1].Add(_Triangle.V1);
                    edges[edges.Length - 1].Add(_Triangle.V1);
                    edges[_Y2 - yMin].Add(_Triangle.V2);
                }
                else if (_Y3 == yMin && _Y2 == yMax)
                {
                    edges[0].Add(_Triangle.V3);
                    edges[0].Add(_Triangle.V3);
                    edges[edges.Length - 1].Add(_Triangle.V2);
                    edges[edges.Length - 1].Add(_Triangle.V2);
                    edges[_Y1 - yMin].Add(_Triangle.V1);
                }
            }
        }

        // Не обрабатывает вырожденные случаи.
        private void RasterizeEdge(ref List<Vertex>[] edges, Vertex v1, Vertex v2)
        {
            int y1 = Maths.Round(v1.Position.Y);
            int y2 = Maths.Round(v2.Position.Y);

            int d = y2 > y1 ? 1 : -1;

            double x1 = v1.Position.X;
            double z1 = v1.Position.Z;

            double x2 = v2.Position.X;
            double z2 = v2.Position.Z;

            double dx = x2 - x1;
            double dy = y2 - y1;
            double dz = z2 - z1;

            for (int y = y1 + d; y != y2; y += d)
            {
                double k = (y - y1) / dy;

                double x = dx * k + x1;
                double z = dz * k + z1;

                edges[y - yMin].Add(new Vertex(x, y, z));
            }
        }

        // Не обрабатывает вырожденные случаи.
        public void RasterizeLine(Triangle3DLine line)
        {
            int x1 = Maths.Round(line.V1.Position.X);
            int x2 = Maths.Round(line.V2.Position.X);

            double y = line.V1.Position.Y;

            double z1 = line.V1.Position.Z;
            double z2 = line.V2.Position.Z;

            double dx = x2 - x1;
            double dz = z2 - z1;

            for (int x = x1 + 1; x < x2; x++)
            {
                double z = ((x - x1) / dx) * dz + z1;

                line[x - x1] = new Vertex(x, y, z);
            }
        }

        private void FindColors()
        {
            for (int i = 0; i < _Lines.Length; i++)
            {
                for (int j = 0; j < _Lines[i].Count; j++)
                {
                    _Lines[i][j].Color = FindColor(_Lines[i][j]);
                }
            }
        }

        private Color FindColor(Vertex v)
        {
            // Направление на источник света.
            Vector3D h = new Vector3D(_Light.Position.X - v.Position.X,
                _Light.Position.Y - v.Position.Y, _Light.Position.Z - v.Position.Z);

            // Косинус угла между нормалью к поверхности и направлением на источник света.
            double cos = Vector3D.CosAngle(_Triangle.Normal, h);

            int r = Maths.Round(_Light.Properties.R * _Triangle.MaterialProperties.KDR * cos);
            int g = Maths.Round(_Light.Properties.G * _Triangle.MaterialProperties.KDG * cos);
            int b = Maths.Round(_Light.Properties.B * _Triangle.MaterialProperties.KDB * cos);

            if (r < 0)
            {
                r = 0;
            }
            if (g < 0)
            {
                g = 0;
            }
            if (b < 0)
            {
                b = 0;
            }

            return Color.FromArgb(r, g, b);
        }
    }
}