namespace Magazine
{
    class FoodSuply : Product
    {
        protected string ShelfLife { get; set; }
        public FoodSuply(string name, uint price, uint count, string unit, string shelfLife) : base(name, price, count, unit)
        {
            ShelfLife = shelfLife;
        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Unit: {Unit}\n" +
                $"Shelf Life: {ShelfLife}.\n";
        }
    }
}