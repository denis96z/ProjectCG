namespace Lungs
{
    interface ILightModification { }

    class LightMovement : SpotSceneObjectMovement, ILightModification
    {
        public LightMovement(double dX, double dY, double dZ) : base(dX, dY, dZ) { }
    }

    class LightRotationOX : SpotSceneObjectRotationOX, ILightModification
    {
        public LightRotationOX(double angle) : base(angle) { }
    }

    class LightRotationOY : SpotSceneObjectRotationOY, ILightModification
    {
        public LightRotationOY(double angle) : base(angle) { }
    }

    class LightRotationOZ : SpotSceneObjectRotationOZ, ILightModification
    {
        public LightRotationOZ(double angle) : base(angle) { }
    }

    class LightScaling : SpotSceneObjectScaling, ILightModification
    {
        public LightScaling(double kX, double kY, double kZ) : base(kX, kY, kZ) { }
    }
}