using System;

namespace Lungs
{
    class Camera : InvisibleSpotSceneObject
    {
        public static readonly Vector3D DEFAULT_POSITION =
            new Vector3D(0, 0, 0);

        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public Camera() : this(DEFAULT_POSITION.Z) { }

        public Camera(double z) : base(DEFAULT_POSITION.X,
            DEFAULT_POSITION.Y, z) { }

        public Camera(Vector3D position) : base(position) { }

        public Camera(Camera camera) : base(camera) { }

        // ------------------------------------------------
        // Модификации.
        // ------------------------------------------------

        public override void Modify(SpotSceneObjectModification modification)
        {
            if (modification is ICameraModification)
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
