using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    internal class Program
    {
        static void Main()
        {
            double priceLollipops = 100;
            double priceChocolates = 200;
            double priceWaffles = 150;
            double priceDragees = 120;


            var economPackageBuilder = new EconomPackageBuilder(priceLollipops, priceChocolates,
                priceWaffles, priceDragees);
            var standartPackageBuilder = new StandartPackageBuilder(priceLollipops, priceChocolates,
                priceWaffles, priceDragees);
            var extraPackageBuilder = new ExtraPackageBuilder(priceLollipops, priceChocolates,
                priceWaffles, priceDragees);

            var shopForYou = new BuySweetPackage(); // Director

            double totalSum = 0; 
            bool isRunning = true; 

            while (isRunning)
            {
                Console.WriteLine("Choose set of sweets to package:");
                Console.WriteLine("1. Lasunka (Econom)");
                Console.WriteLine("2. Namunayko (Standart)");
                Console.WriteLine("3. Pan Koc'kuy (Extra)");
                Console.WriteLine("4. Finish and calculate the total");
                Console.Write("\nYour choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                SweetPackage sweetPackage;

                switch (choice)
                {
                    case "1":
                        shopForYou.SetPackageBuilder(economPackageBuilder);
                        shopForYou.ConstructSweetPackage();
                        sweetPackage = shopForYou.GetSweetPackage();
                        Console.WriteLine(sweetPackage.ToString());
                        totalSum += sweetPackage.TotalPrice;
                        break;

                    case "2":
                        shopForYou.SetPackageBuilder(standartPackageBuilder);
                        shopForYou.ConstructSweetPackage();
                        sweetPackage = shopForYou.GetSweetPackage();
                        Console.WriteLine(sweetPackage.ToString());
                        totalSum += sweetPackage.TotalPrice;
                        break;

                    case "3":
                        shopForYou.SetPackageBuilder(extraPackageBuilder);
                        shopForYou.ConstructSweetPackage();
                        sweetPackage = shopForYou.GetSweetPackage();
                        Console.WriteLine(sweetPackage.ToString());
                        totalSum += sweetPackage.TotalPrice;
                        break;

                    case "4":
                        Console.WriteLine($"\nTotal sum of all sweet packages: {totalSum} uah");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input..");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
