namespace Lungs
{
    class Scene
    {
        private Model _Model = null;
        private Light _Light;
        private Camera _Camera;

        public Scene()
        {
            _Light = new Light(LightProperties.WhiteLight);
            _Camera = new Camera(Camera.DEFAULT_POSITION);
        }

        public Model Model
        {
            get { return _Model; }
            set { _Model = value; }
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
    }
}