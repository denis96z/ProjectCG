namespace Lungs
{
    class ZBuffer
    {
        public const double INIT_VALUE = double.MaxValue;

        private double[,] _Items;
        private int _Width, _Height;

        public ZBuffer(int width, int height)
        {
            _Items = new double[width, height];
            _Width = width;
            _Height = height;
        }

        public bool SetValue(int x, int y, double z)
        {
            if (z < _Items[x, y])
            {
                _Items[x, y] = z;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double this[int x, int y]
        {
            get { return _Items[x, y]; }
        }

        public double Width
        {
            get { return _Width; }
        }

        public double Height
        {
            get { return _Height; }
        }

        public void Clear()
        {
            for (int x = 0; x < _Width; x++)
            {
                for (int y = 0; y < _Height; y++)
                {
                    _Items[x, y] = INIT_VALUE;
                }
            }
        }
    }
}