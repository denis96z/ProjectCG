namespace Lungs
{
    abstract class Vector { }

    class Vector3D : Vector
    {
        public const int LENGTH = 4;

        public const int X_INDEX = 0;
        public const int Y_INDEX = 1;
        public const int Z_INDEX = 2;
        public const int O_INDEX = 3;

        public const int DEFAULT_X_VALUE = 0;
        public const int DEFAULT_Y_VALUE = 0;
        public const int DEFAULT_Z_VALUE = 0;

        private double[] _Coordinates;

        // ------------------------------------------------
        // Конструкторы.
        // ------------------------------------------------

        public Vector3D()
        {
            _Coordinates = new double[LENGTH];

            if (_Coordinates == null)
            {
                throw new MemoryAllocationException();
            }

            _Coordinates[X_INDEX] = DEFAULT_X_VALUE;
            _Coordinates[Y_INDEX] = DEFAULT_Y_VALUE;
            _Coordinates[Z_INDEX] = DEFAULT_Y_VALUE;
            _Coordinates[O_INDEX] = 1;
        }

        public Vector3D(double x, double y, double z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D(Vector3D vector) : this()
        {
            X = vector.X;
            Y = vector.Y;
            Z = vector.Z;
        }

        // ------------------------------------------------
        // Установка значений.
        // ------------------------------------------------

        public void Set(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X
        {
            get { return _Coordinates[X_INDEX]; }
            set { _Coordinates[X_INDEX] = value; }
        }

        public double Y
        {
            get { return _Coordinates[Y_INDEX]; }
            set { _Coordinates[Y_INDEX] = value; }
        }

        public double Z
        {
            get { return _Coordinates[Z_INDEX]; }
            set { _Coordinates[Z_INDEX] = value; }
        }

        public double this[int index]
        {
            get { return _Coordinates[index]; }
            set { _Coordinates[index] = value; }
        }

        public double Length
        {
            get
            {
                return Maths.Sqrt(Maths.Sqr(X) + Maths.Sqr(Y) + Maths.Sqr(Z));
            }
        }

        public void Normalize()
        {
            double length = Length;

            X /= length;
            Y /= length;
            Z /= length;
        }

        public static double CosAngle(Vector3D v1, Vector3D v2)
        {
            return (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z) / (v1.Length * v2.Length);
        }

        // ------------------------------------------------
        // Приведение типов.
        // ------------------------------------------------

        public double[] ToArray()
        {
            return (double[])_Coordinates.Clone();
        }

        public static Vector3D FromArray(double[] array)
        {
            return new Vector3D(array[X_INDEX], array[Y_INDEX],
                array[Z_INDEX]);
        }
    }
}