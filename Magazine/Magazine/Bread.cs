namespace Magazine
{
    class Bread : FoodSuply
    {
        public string TypeOfFlour { get; set; }
        public Bread(string name, uint price, uint count, string unit, string shelfLife, string typeOfFlour)
            : base(name, price, count, unit, shelfLife)
        {
            TypeOfFlour = typeOfFlour;
        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\nCount: {Count};\n" +
                $"Unit: {Unit};\n" +
                $"Shelf Life: {ShelfLife};\n" +
                $"Type of flour: {TypeOfFlour}.\n";
        }
    }
}