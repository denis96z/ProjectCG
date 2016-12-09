using System.Xml;

namespace Lungs
{
    class FileManager
    {
        public FileManager() { }

        public Scene LoadModel(string fileName)
        {
            ModelFileReader mfr = new ModelFileReader(fileName);
            Scene scene = mfr.GetModel();
            return scene;
        }
    }

    class ModelFileReader
    {
        private XmlDocument _XMLModel;

        public ModelFileReader(string fileName)
        {
            _XMLModel = new XmlDocument();
            _XMLModel.Load(fileName);
        }

        public Scene GetModel()
        {
            XmlElement xModel = _XMLModel.DocumentElement;

            Scene scene = new Scene();

            foreach (XmlNode xTriangle in xModel)
            {
                Vector3D n = GetNormal(xTriangle);
                Vertex v1 = GetVertex(xTriangle, "vertex1");
                Vertex v2 = GetVertex(xTriangle, "vertex2");
                Vertex v3 = GetVertex(xTriangle, "vertex3");
                MaterialProperties mp = GetMaterial(xTriangle);
                Triangle3D t = new Triangle3D(v1, v2, v3, n, mp);
                scene.Model.AddTriangle(t);
            }

            return scene;
        }

        private Vector3D GetNormal(XmlNode xTriangle)
        {
            XmlNode xNormal = xTriangle.SelectSingleNode("normal");

            double x = double.Parse(xNormal.Attributes["x"].Value);
            double y = double.Parse(xNormal.Attributes["y"].Value);
            double z = double.Parse(xNormal.Attributes["z"].Value);

            return new Vector3D(x, y, z);
        }

        private Vertex GetVertex(XmlNode xTriangle, string name)
        {
            XmlNode xVertex = xTriangle.SelectSingleNode(name);

            double x = double.Parse(xVertex.Attributes["x"].Value);
            double y = double.Parse(xVertex.Attributes["y"].Value);
            double z = double.Parse(xVertex.Attributes["z"].Value);

            return new Vertex(x, y, z);
        }

        private MaterialProperties GetMaterial(XmlNode xTriangle)
        {
            XmlNode xMaterial = xTriangle.SelectSingleNode("material");

            double kr = double.Parse(xMaterial.Attributes["kr"].Value);
            double kg = double.Parse(xMaterial.Attributes["kg"].Value);
            double kb = double.Parse(xMaterial.Attributes["kb"].Value);

            return new MaterialProperties(kr, kg, kb);
        }
    }
}