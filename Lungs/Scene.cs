using System.Collections.Generic;

namespace Lungs
{
    class Scene
    {
        private List<Triangle3D> _Triangles;
        private Light _Light;
        private Camera _Camera;

        public Scene()
        {
            _Triangles = new List<Triangle3D>();
            _Light = new Light(LightProperties.WhiteLight);
            _Camera = new Camera(Camera.DEFAULT_POSITION);
        }

        public int TrianglesCount
        {
            get { return _Triangles.Count; }
        }


        public Light Light
        {
            get { return _Light; }
            set { _Light = value; }
        }

        public Camera Camera
        {
            get { return _Camera; }
        }

        public void AddTriangle(Triangle3D triangle)
        {
            _Triangles.Add(triangle);
        }

        public Triangle3D GetTriangle(int index)
        {
            return _Triangles[index];
        }

        public void ModifyTriangles(SpotSceneObjectModification modification)
        {
            foreach (var t in _Triangles)
            {
                t.Modify(modification);
            }
        }
    }
}