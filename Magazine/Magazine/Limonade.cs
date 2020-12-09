namespace Magazine
{
    class Limonade : Drinks
    {
        public Limonade(string name, uint price, uint count, string unit, double volume)
    : base(name, price, count, unit, volume)
        {

        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Volume: {Volume} { Unit}.\n";
        }
    }
}