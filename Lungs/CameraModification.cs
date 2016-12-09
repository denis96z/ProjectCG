namespace Lungs
{
    interface ICameraModification { }

    class CameraMovementOZ : SpotSceneObjectMovement, ICameraModification
    {
        public CameraMovementOZ(double dZ) : base(0, 0, dZ) { }
    }
}