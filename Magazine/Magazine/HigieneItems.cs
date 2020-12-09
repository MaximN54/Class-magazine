using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class HigieneItems:Product
    {
        public uint CountInPerPack { get; private set; }
        public HigieneItems(string name, uint price, uint count, string unit, uint countInPerPack) : base(name, price, count, unit)
        {
            CountInPerPack = countInPerPack;
        }
        public override string ToString()
        {
            return $"Name: {Name};\n" +
                $"Price: {Price};\n" +
                $"Count: {Count};\n" +
                $"Unit: {Unit}\n" +
                $"Volume: {CountInPerPack}.\n";
        }
    }
}
