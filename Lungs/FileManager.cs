using System.IO;

namespace Lungs
{
    class FileManager
    {
        private string _FileName;
        private StreamReader _FileReader;

        public FileManager(string fileName)
        {
            _FileName = fileName;
            _FileReader = new StreamReader(fileName);
        }

        public void LoadScene(Scene scene)
        {
            _FileReader.ReadLine();

            string s = null;
            char[] splitters = new char[] { ' ' };

            MaterialProperties mp = new MaterialProperties(0.85, 0.54, 0.148);

            while ((s = _FileReader.ReadLine().TrimStart()) != null)
            {
                string[] items = s.Replace('.', ',').Split(splitters);

                if (items[0] != "facet")
                {
                    break;
                }

                Vector3D normal = new Vector3D(double.Parse(items[2]),
                    double.Parse(items[3]), double.Parse(items[4]));

                _FileReader.ReadLine();

                items = _FileReader.ReadLine().TrimStart().Replace('.', ',').Split(splitters);
                Vertex v1 = new Vertex(double.Parse(items[1]),
                    double.Parse(items[2]), double.Parse(items[3]));

                items = _FileReader.ReadLine().TrimStart().Replace('.', ',').Split(splitters);
                Vertex v2 = new Vertex(double.Parse(items[1]),
                    double.Parse(items[2]), double.Parse(items[3]));

                items = _FileReader.ReadLine().TrimStart().Replace('.', ',').Split(splitters);
                Vertex v3 = new Vertex(double.Parse(items[1]),
                    double.Parse(items[2]), double.Parse(items[3]));

                _FileReader.ReadLine();
                _FileReader.ReadLine();

                scene.AddTriangle(new Triangle3D(v1, v2, v3, normal, mp));
            }
        }
    }
}