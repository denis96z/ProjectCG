namespace Lungs
{
    interface IVertexModification { }

    class VertexMovement : SpotSceneObjectMovement, IVertexModification
    {
        public VertexMovement(double dX, double dY, double dZ) : base(dX, dY, dZ) { }
    }

    interface IVertexRotation { }

    class VertexRotationOX : SpotSceneObjectRotationOX, IVertexModification, IVertexRotation
    {
        public VertexRotationOX(double angle) : base(angle) { }
    }

    class VertexRotationOY : SpotSceneObjectRotationOY, IVertexModification, IVertexRotation
    {
        public VertexRotationOY(double angle) : base(angle) { }
    }

    class VertexRotationOZ : SpotSceneObjectRotationOZ, IVertexModification, IVertexRotation
    {
        public VertexRotationOZ(double angle) : base(angle) { }
    }

    class VertexScaling : SpotSceneObjectScaling, IVertexModification
    {
        public VertexScaling(double kX, double kY, double kZ) : base(kX, kY, kZ) { }
    }
}