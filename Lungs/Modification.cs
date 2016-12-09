namespace Lungs
{
    abstract class Modification { }

    class SpotSceneObjectModification : Modification
    {
        protected ModificationMatrix3D _Matrix;

        protected SpotSceneObjectModification()
        {
            _Matrix = new ModificationMatrix3D();
        }

        public virtual void ApplyTo(SpotSceneObject sceneObject)
        {
            sceneObject.Position = Vector3D.FromArray(_Matrix * sceneObject.Position.ToArray());
        }

        public ModificationMatrix3D Matrix
        {
            get { return _Matrix; }
        }
    }

    class SpotSceneObjectMovement : SpotSceneObjectModification
    {
        public SpotSceneObjectMovement(double dX, double dY, double dZ)
        {
            _Matrix = new MovementMatrix(dX, dY, dZ);
        }
    }

    class SpotSceneObjectRotation : SpotSceneObjectModification { }

    class SpotSceneObjectRotationOX : SpotSceneObjectRotation
    {
        public SpotSceneObjectRotationOX(double angle)
        {
            _Matrix = new RotationMatrixOX3D(angle);
        }
    }

    class SpotSceneObjectRotationOY : SpotSceneObjectRotation
    {
        public SpotSceneObjectRotationOY(double angle)
        {
            _Matrix = new RotationMatrixOY3D(angle);
        }
    }

    class SpotSceneObjectRotationOZ : SpotSceneObjectRotation
    {
        public SpotSceneObjectRotationOZ(double angle)
        {
            _Matrix = new RotationMatrixOZ3D(angle);
        }
    }

    class SpotSceneObjectScaling : SpotSceneObjectModification
    {
        public SpotSceneObjectScaling(double kX, double kY, double kZ)
        {
            _Matrix = new ScalingMatrix3D(kX, kY, kZ);
        }
    }
}