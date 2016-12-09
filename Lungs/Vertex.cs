using System.Drawing;

namespace Lungs
{
    class Vertex : VisibleSpotSceneObject
    {
        private Color _Color;
        private bool _IsShadowed;

        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public Vertex() : this(Vector3D.DEFAULT_X_VALUE,
            Vector3D.DEFAULT_Y_VALUE, Vector3D.DEFAULT_Z_VALUE) { }

        public Vertex(double x, double y, double z) : base(x, y, z) { }
        public Vertex(Vector3D position) : base(position) { }
        public Vertex(Vertex vertex) : base(vertex) { }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public Color Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public bool Shadowed
        {
            get { return _IsShadowed; }
            set { _IsShadowed = value; }
        }

        // ------------------------------------------------
        // Модификации.
        // ------------------------------------------------

        public override void Modify(SpotSceneObjectModification modification)
        {
            if (modification is IVertexModification)
            {
                modification.ApplyTo(this);
            }
            else
            {
                throw new IllegalModificationException();
            }
        }
    }
}
