using System.Collections.Generic;

namespace Lungs
{
    class Scene
    {
        private Model _Model;
        private Light _Light;
        private Camera _Camera;

        public Scene()
        {
            _Model = new Model();
            _Light = new Light(LightProperties.WhiteLight);
            _Camera = new Camera(Camera.DEFAULT_POSITION);
        }

        public Model Model
        {
            get { return _Model; }
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