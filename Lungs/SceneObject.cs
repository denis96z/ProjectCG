namespace Lungs
{
    abstract class SceneObject { }

    abstract class SpotSceneObject : SceneObject
    {
        private Vector3D _Position;

        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        protected SpotSceneObject() : this(Vector3D.DEFAULT_X_VALUE,
            Vector3D.DEFAULT_Y_VALUE, Vector3D.DEFAULT_Z_VALUE) { }

        protected SpotSceneObject(double x, double y, double z)
        {
            _Position = new Vector3D(x, y, z);
        }

        protected SpotSceneObject(Vector3D position)
        {
            _Position = new Vector3D(position);
        }

        protected SpotSceneObject(SpotSceneObject spotSceneObject)
        {
            _Position = new Vector3D(spotSceneObject._Position);
        }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public Vector3D Position
        {
            get { return _Position; }
            set { _Position.Set(value.X, value.Y, value.Z); }
        }

        public abstract void Modify(SpotSceneObjectModification modification);

        // ------------------------------------------------
        // Преобразование типов.
        // ------------------------------------------------

        public override string ToString()
        {
            return "X: " + Position.X.ToString() +
                " Y: " + Position.Y.ToString() +
                " Z: " + Position.Z.ToString();
        }
    }

    abstract class VisibleSpotSceneObject : SpotSceneObject
    {
        protected VisibleSpotSceneObject() : this(Vector3D.DEFAULT_X_VALUE, 
            Vector3D.DEFAULT_Y_VALUE, Vector3D.DEFAULT_Z_VALUE) { }

        protected VisibleSpotSceneObject(double x, double y, double z) :
            base(x, y, z) { }

        protected VisibleSpotSceneObject(Vector3D position) : base(position) { }

        protected VisibleSpotSceneObject(VisibleSpotSceneObject visibleSpotSceneObject) :
            base(visibleSpotSceneObject) { }
    }

    abstract class InvisibleSpotSceneObject : SpotSceneObject
    {
        protected InvisibleSpotSceneObject() : this(Vector3D.DEFAULT_X_VALUE, 
            Vector3D.DEFAULT_Y_VALUE, Vector3D.DEFAULT_Z_VALUE) { }

        protected InvisibleSpotSceneObject(double x, double y, double z) :
            base(x, y, z) { }

        protected InvisibleSpotSceneObject(Vector3D position) : base(position) { }

        protected InvisibleSpotSceneObject(InvisibleSpotSceneObject visibleSpotSceneObject) :
            base(visibleSpotSceneObject) { }
    }

    abstract class ComplexSceneObject : SceneObject
    {
        //public abstract void Modify(CSceneObjectModification modification);
    }
}
