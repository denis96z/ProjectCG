namespace Lungs
{
    class Light : VisibleSpotSceneObject
    {
        private LightProperties _Properties;

        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public Light(LightProperties properties) :
            this(Vector3D.DEFAULT_X_VALUE, Vector3D.DEFAULT_Y_VALUE,
                Vector3D.DEFAULT_Z_VALUE, properties) { }

        public Light(double x, double y, double z, LightProperties properties) :
            base(x, y, z)
        {
            _Properties = properties;
        }

        public Light(Vector3D position, LightProperties properties) :
            base(position)
        {
            _Properties = properties;
        }

        public Light(Light light) : base(light)
        {
            _Properties = light._Properties;
        }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public LightProperties Properties
        {
            get { return _Properties; }
            set { _Properties = value; }
        }

        // ------------------------------------------------
        // Модификации.
        // ------------------------------------------------

        public override void Modify(SpotSceneObjectModification modification)
        {
            if (modification is ILightModification)
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
