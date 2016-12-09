namespace Lungs
{
    struct LightProperties
    {
        public const int PROPERTY_VECTOR_LENGTH = 3;

        public const int R_INDEX = 0;
        public const int G_INDEX = 1;
        public const int B_INDEX = 2;

        public const int MAX_PROPERTY_VALUE = 255;
        public const int MIN_PROPERTY_VALUE = 0;

        private int[] _I;

        public LightProperties(int r, int g, int b)
        {
            _I = new int[PROPERTY_VECTOR_LENGTH];

            _I[R_INDEX] = r;
            _I[G_INDEX] = g;
            _I[B_INDEX] = b;
        }

        public int R
        {
            get { return _I[R_INDEX]; }
            set { _I[R_INDEX] = value; }
        }

        public int G
        {
            get { return _I[G_INDEX]; }
            set { _I[G_INDEX] = value; }
        }

        public int B
        {
            get { return _I[B_INDEX]; }
            set { _I[B_INDEX] = value; }
        }

        public int this[int index]
        {
            get { return _I[index]; }
            set { _I[index] = value; }
        }

        public static LightProperties WhiteLight
        {
            get
            {
                return new LightProperties(MAX_PROPERTY_VALUE,
                    MAX_PROPERTY_VALUE, MAX_PROPERTY_VALUE);
            }
        }

        public override string ToString()
        {
            return "Ir: " + _I[R_INDEX].ToString() +
                " Ig: " + _I[G_INDEX].ToString() +
                " Ib: " + _I[B_INDEX].ToString();
        }
    }
}