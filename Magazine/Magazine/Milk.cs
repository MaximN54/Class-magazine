namespace Magazine
{
    class Milk : Drinks
    {
        private double _percentageOfFat;
        public double PercentageOfFat
        {
            get => _percentageOfFat;
            set
            {
                if (PercentageOfFat >= 0)
                    _percentageOfFat = value;
            }
        }
        public string ShelfLife { get; set; }
        public Milk(string name, uint price, uint count, string unit, double volume, double percentageOfFat, string shelfLife)
            : base(name, price, count, unit, volume)
        {
            PercentageOfFat = percentageOfFat;
            ShelfLife = shelfLife;
        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Volume: {Volume} { Unit}\n" +
                $"Percentage of fat: {PercentageOfFat};\n" +
                $"Shelf life: {ShelfLife}.\n";
        }
    }
}