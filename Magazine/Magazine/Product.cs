namespace Magazine
{
    internal class Product
    {
        protected string Name { get; set; }
        protected uint Price { get; set; }
        protected uint Count { get; set; }
        protected string Unit { get; set; }

        public Product(string name, uint price, uint count, string unit)
        {
            Name = name;
            Price = price;
            Count = count;
            Unit = unit;
        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Unit: {Unit}.\n";
        }
    }
}
