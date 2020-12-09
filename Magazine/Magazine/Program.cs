using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Program
    {
            public static void showInfo(Product p)
            {
                Console.WriteLine(p.ToString());
            }
            static void Main(string[] args)
            {
                Eggs eggs = new Eggs("Eggs", 64, "19.12.2019", 1000, "unit", 10);
                showInfo(eggs);

                Bread bread = new Bread("Bread", 40, 100, "unit", "22.11.2020", "premium");
                showInfo(bread);

                Baby baby = new Baby("Baby", 700, 1000, "unit", 1, true, 0, 8, "panties");
                showInfo(baby);

                Nipple nipple = new Nipple("Nipple", 150, 1000, "unit", 0, true);
                showInfo(nipple);

                Milk milk = new Milk("Milk", 65, 1000, "litr", 0.9, 2.5, "25.11.2019");
                showInfo(milk);

                Limonade limonade = new Limonade("Cola", 80, 1000, "unit", 1.5);
                showInfo(limonade);

                ToiletePaper toiletePaper = new ToiletePaper("Zeva", 300, 1000, "unit", 8, 3);
            showInfo(toiletePaper);

            Mask mask = new Mask("Mask", 100, 1000, "unit", 1);
            showInfo(mask);

                Console.ReadLine();

            }
        }
}
