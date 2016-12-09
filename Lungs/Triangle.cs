namespace Lungs
{
    abstract class Triangle { }

    class Triangle3D : SceneObject
    {
        public const int VERTEXES_COUNT = 3;

        public const int V1_INDEX = 0;
        public const int V2_INDEX = 1;
        public const int V3_INDEX = 2;
        public const int VA_INDEX = 3;

        private Vertex[] _Vertexes;
        private Vector3D _Normal;

        private MaterialProperties _MaterialProperties;

        public Triangle3D(Vertex v1, Vertex v2, Vertex v3, Vector3D normal, MaterialProperties mp)
        {
            _Vertexes = new Vertex[VERTEXES_COUNT + 1];

            _Vertexes[V1_INDEX] = new Vertex(v1);
            _Vertexes[V2_INDEX] = new Vertex(v2);
            _Vertexes[V3_INDEX] = new Vertex(v3);
            _Vertexes[VA_INDEX] = _Vertexes[V1_INDEX];

            _Normal = new Vector3D(normal);

            _MaterialProperties = mp;
        }

        public Vertex V1
        {
            get { return _Vertexes[V1_INDEX]; }
        }

        public Vertex V2
        {
            get { return _Vertexes[V2_INDEX]; }
        }

        public Vertex V3
        {
            get { return _Vertexes[V3_INDEX]; }
        }

        public Vector3D Normal
        {
            get { return _Normal; }
        }

        public Vertex this[int index]
        {
            get { return _Vertexes[index]; }
        }

        public MaterialProperties MaterialProperties
        {
            get { return _MaterialProperties; }
        }

        public virtual void Modify(SpotSceneObjectModification modification)
        {
            for (int i = 0; i < VERTEXES_COUNT; i++)
            {
                _Vertexes[i].Modify(modification);
            }

            _Normal = Vector3D.FromArray(modification.Matrix * _Normal.ToArray());
            _Normal.Normalize();
        }
    }
}