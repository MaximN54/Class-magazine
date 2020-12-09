namespace Magazine
{
    class Drinks : Product
    {
        private double _volum;
        protected double Volume
        {
            get => _volum;
            set
            {
                if (value >= 0)
                    _volum = value;
            }
        }
        public Drinks(string name, uint price, uint count, string unit, double volume) : base(name, price, count, unit)
        {
            Volume = volume;
        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Unit: {Unit}\n" +
                $"Volume: {Volume}.\n";
        }
    }
}