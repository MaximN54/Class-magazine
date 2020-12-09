namespace Magazine
{
    internal class Baby: ChildrenProducts
    {
        protected uint Size { get; set; }
        public uint MinimumWeight { get; set; }
        public uint MaximumWeight { get; set; }
        public string Type { get; set; }
        public Baby(string name, uint price, uint count, string unit, uint minimumAge, bool hypoallergenic, uint minimumWeight, uint maximumWeight, string type)
            : base(name, price, count, unit, minimumAge, hypoallergenic)
        {
            MinimumWeight = minimumWeight;
            MaximumWeight = maximumWeight;
            Type = type;
        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Unit: {Unit}\n" +
                $"Minimum age: {MinimumAge};\n" +
                $"Hypoallergenic: {_hipoallergenicIsTrueOreFalse};\n" +
                $"Weight: {MinimumWeight} - {MaximumWeight};\n" +
                $"Type: {Type}.\n";
        }
    }
}