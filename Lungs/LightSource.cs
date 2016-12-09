namespace Lungs
{
    struct LightProperties
    {
        public const int PROPERTY_VECTOR_LENGTH = 3;

        private int[] _I;

        public LightProperties(int[] intensity)
        {
            _I = (int[])intensity.Clone();
        }

        public int[] I
        {
            get
            {
                return _I;
            }

            set
            {
                value.CopyTo(_I, 0);
            }
        }

        public override string ToString()
        {
            return "Ir: " + _I[Constants.RGB_RED_INDEX].ToString() +
                " Ig: " + _I[Constants.RGB_GREEN_INDEX].ToString() +
                " Ib: " + _I[Constants.RGB_BLUE_INDEX].ToString();
        }
    }
}