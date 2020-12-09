namespace Magazine
{
    class ChildrenProducts : Product
    {
        protected uint MinimumAge { get; set; }
        protected bool Hypoallergenic { get; set; }
        protected string _hipoallergenicIsTrueOreFalse;
        public ChildrenProducts(string name, uint price, uint count, string unit, uint minimumAge, bool hypoallergenic) : base(name, price, count, unit)
        {
            MinimumAge = minimumAge;
            Hypoallergenic = hypoallergenic;
            if (hypoallergenic == true)
                _hipoallergenicIsTrueOreFalse = $"The {Name} is hypoallergenic";
            else
                _hipoallergenicIsTrueOreFalse = $"The {Name} is not hypoallergenic";
        }

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