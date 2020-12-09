namespace Magazine
{
    class Nipple : ChildrenProducts
    {

        public Nipple(string name, uint price, uint count, string unit, uint minimumAge, bool hypoallergenic)
            : base(name, price, count, unit, minimumAge, hypoallergenic)
        { }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Unit: {Unit}\n" +
                $"Minimum age: {MinimumAge};\n" +
                $"Hypoallergenic: {_hipoallergenicIsTrueOreFalse}.\n";
        }
    }
}