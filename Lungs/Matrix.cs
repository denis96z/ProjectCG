namespace Lungs
{
    class Matrix
    {
        protected double[,] _Elements;

        protected int _RowCount;
        protected int _ColCount;

        public Matrix(int rowCount, int colCount)
        {
            _Elements = new double[rowCount, colCount];

            _RowCount = rowCount;
            _ColCount = colCount;

            Zero();
        }

        public int RowCount
        {
            get { return _RowCount; }
        }

        public int ColCount
        {
            get { return _ColCount; }
        }

        public void Zero()
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    _Elements[i, j] = 0;
                }
            }
        }

        public void Init()
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    _Elements[i, j] = 1;
                }
            }
        }

        public static double[] operator *(Matrix matrix, double[] vector)
        {
            if (matrix.RowCount != vector.Length)
            {
                throw new System.Exception();
            }

            double[] r = new double[vector.Length];

            for (int i = 0; i < vector.Length; i++)
            {
                r[i] = 0;
                for (int j = 0; j < matrix.ColCount; j++)
                {
                    r[i] += matrix._Elements[i, j] * vector[j];
                }
            }

            return r;
        }
    }

    class Matrix3D : Matrix
    {
        public Matrix3D() : base(Vector3D.LENGTH, Vector3D.LENGTH) { }
    }
}
