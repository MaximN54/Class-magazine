namespace Magazine
{
    internal class ToiletePaper: HigieneItems
    {
        public uint Layers { get; private set; }
        public ToiletePaper(string name, uint price, uint count, string unit, uint countInPerPack, uint layers) : base(name,price,count,unit,countInPerPack)
        {
            Layers = layers;
        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Unit: {Unit}\n" +
                $"CountInPerPack: {CountInPerPack}.\n" +
                $"Layers: {Layers}";
        }
    }
}