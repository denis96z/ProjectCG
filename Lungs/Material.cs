namespace Lungs
{
    struct MaterialProperties
    {
        public const int PROPERTY_VECTOR_LENGTH = 3;

        public const int R_INDEX = 0;
        public const int G_INDEX = 1;
        public const int B_INDEX = 2;

        public const double MAX_PROPERTY_VALUE = 1;
        public const double MIN_PROPERTY_VALUE = 0;

        private double[] _KD;

        public MaterialProperties(double kDR, double kDG, double kDB)
        {
            _KD = new double[PROPERTY_VECTOR_LENGTH];

            _KD[R_INDEX] = kDR;
            _KD[G_INDEX] = kDG;
            _KD[B_INDEX] = kDB;
        }

        public double KDR
        {
            get { return _KD[R_INDEX]; }
            set { _KD[R_INDEX] = value; }
        }

        public double KDG
        {
            get { return _KD[G_INDEX]; }
            set { _KD[G_INDEX] = value; }
        }

        public double KDB
        {
            get { return _KD[B_INDEX]; }
            set { _KD[B_INDEX] = value; }
        }

        public double this[int index]
        {
            get { return _KD[index]; }
            set { _KD[index] = value; }
        }

        public override string ToString()
        {
            return "KDr: " + _KD[R_INDEX].ToString() +
                "KDg: " + _KD[G_INDEX].ToString() +
                "KDb: " + _KD[B_INDEX].ToString();
        }
    }
}
