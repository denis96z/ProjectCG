using System.Collections;
using System.Collections.Generic;

namespace Lungs
{
    class Model : IEnumerable<Triangle3D>
    {
        private List<Triangle3D> _Triangles;

        public Model()
        {
            _Triangles = new List<Triangle3D>();
        }

        public void AddTriangle(Triangle3D triangle)
        {
            _Triangles.Add(triangle);
        }

        public void RemoveTriangle(int index)
        {
            _Triangles.RemoveAt(index);
        }

        public int TrianglesCount
        {
            get { return _Triangles.Count; }
        }

        public Triangle3D this[int index]
        {
            get { return _Triangles[index]; }
        }

        public void Modify(SpotSceneObjectModification modification)
        {
            foreach (var t in _Triangles)
            {
                t.Modify(modification);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Triangles.GetEnumerator();
        }

        public IEnumerator<Triangle3D> GetEnumerator()
        {
            return _Triangles.GetEnumerator();
        }
    }
}
