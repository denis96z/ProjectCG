using System;

namespace Lungs
{
    class ModificationMatrix3D : Matrix3D
    {
        public ModificationMatrix3D()
        {
            Init();
        }
    }

    class MovementMatrix : ModificationMatrix3D
    {
        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public MovementMatrix(double dX, double dY, double dZ)
        {
            Zero();

            Set(dX, dY, dZ);

            for (int i = 0; i < Vector3D.LENGTH; i++)
            {
                _Elements[i, i] = 1;
            }
        }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public double DX
        {
            set
            {
                _Elements[Vector3D.X_INDEX, Vector3D.O_INDEX] = value;
            }
        }

        public double DY
        {
            set
            {
                _Elements[Vector3D.Y_INDEX, Vector3D.O_INDEX] = value;
            }
        }

        public double DZ
        {
            set
            {
                _Elements[Vector3D.Z_INDEX, Vector3D.O_INDEX] = value;
            }
        }

        public void Set(double dX, double dY, double dZ)
        {
            DX = dX;
            DY = dY;
            DZ = dZ;
        }
    }

    abstract class RotationMatrix3D : ModificationMatrix3D
    {
        protected double _Angle;
    }

    class RotationMatrixOX3D : RotationMatrix3D
    {
        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public RotationMatrixOX3D(double angle)
        {
            Zero();

            Angle = angle;

            _Elements[Vector3D.X_INDEX, Vector3D.X_INDEX] = 1;
            _Elements[Vector3D.O_INDEX, Vector3D.O_INDEX] = 1;
        }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public double Angle
        {
            get
            {
                return _Angle;
            }

            set
            {
                _Angle = value;

                double sin = Math.Sin(value);
                double cos = Math.Cos(value);

                _Elements[Vector3D.Y_INDEX, Vector3D.Y_INDEX] = cos;
                _Elements[Vector3D.Y_INDEX, Vector3D.Z_INDEX] = -sin;

                _Elements[Vector3D.Z_INDEX, Vector3D.Y_INDEX] = sin;
                _Elements[Vector3D.Z_INDEX, Vector3D.Z_INDEX] = cos;
            }
        }
    }

    class RotationMatrixOY3D : RotationMatrix3D
    {
        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public RotationMatrixOY3D(double angle)
        {
            Zero();

            Angle = angle;

            _Elements[Vector3D.Y_INDEX, Vector3D.Y_INDEX] = 1;
            _Elements[Vector3D.O_INDEX, Vector3D.O_INDEX] = 1;
        }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public double Angle
        {
            get
            {
                return _Angle;
            }

            set
            {
                _Angle = value;

                double sin = Math.Sin(value);
                double cos = Math.Cos(value);

                _Elements[Vector3D.X_INDEX, Vector3D.X_INDEX] = cos;
                _Elements[Vector3D.X_INDEX, Vector3D.Z_INDEX] = sin;

                _Elements[Vector3D.Z_INDEX, Vector3D.X_INDEX] = -sin;
                _Elements[Vector3D.Z_INDEX, Vector3D.Z_INDEX] = cos;
            }
        }
    }

    class RotationMatrixOZ3D : RotationMatrix3D
    {
        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public RotationMatrixOZ3D(double angle)
        {
            Zero();

            Angle = angle;

            _Elements[Vector3D.Z_INDEX, Vector3D.Z_INDEX] = 1;
            _Elements[Vector3D.O_INDEX, Vector3D.O_INDEX] = 1;
        }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public double Angle
        {
            get
            {
                return _Angle;
            }

            set
            {
                _Angle = value;

                double sin = Math.Sin(value);
                double cos = Math.Cos(value);

                _Elements[Vector3D.X_INDEX, Vector3D.X_INDEX] = cos;
                _Elements[Vector3D.X_INDEX, Vector3D.Y_INDEX] = -sin;

                _Elements[Vector3D.Y_INDEX, Vector3D.X_INDEX] = sin;
                _Elements[Vector3D.Y_INDEX, Vector3D.Y_INDEX] = cos;
            }
        }
    }

    class ScalingMatrix3D : ModificationMatrix3D
    {
        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public ScalingMatrix3D(double kX, double kY, double kZ)
        {
            Zero();

            Set(kX, kY, kZ);

            _Elements[Vector3D.O_INDEX, Vector3D.O_INDEX] = 1;
        }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public double KX
        {
            set
            {
                _Elements[Vector3D.X_INDEX, Vector3D.X_INDEX] = value;
            }
        }

        public double KY
        {
            set
            {
                _Elements[Vector3D.Y_INDEX, Vector3D.Y_INDEX] = value;
            }
        }

        public double KZ
        {
            set
            {
                _Elements[Vector3D.Z_INDEX, Vector3D.Z_INDEX] = value;
            }
        }

        public void Set(double kX, double kY, double kZ)
        {
            KX = kX;
            KY = kY;
            KZ = kZ;
        }
    }
}
