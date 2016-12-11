namespace Lungs
{
    class Light : VisibleSpotSceneObject
    {
        public static readonly Vector3D DEFAULT_POSITION =
            new Vector3D(0, 0, -200);

        private LightProperties _Properties;

        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public Light(LightProperties properties) :
            this(DEFAULT_POSITION.X, DEFAULT_POSITION.Y, DEFAULT_POSITION.Z, properties) { }

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
