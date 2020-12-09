namespace Magazine
{
    class Eggs : FoodSuply
    {
        public uint NumberEggs { get; set; }
        public Eggs(string name, uint price, string shelfLife, uint count, string unit, uint numberEggs)
            : base(name, price, count, unit, shelfLife)
        {
            NumberEggs = numberEggs;

        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\nUnit: {Unit};\n" +
                $"Shelf Life: {ShelfLife};\n" +
                $"Number eggs of per pepper: {NumberEggs}.\n";
        }
    }
}