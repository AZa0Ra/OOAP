using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    interface ISoldier
    {
        string Name { get; }
        void Marsh();
    }

    class Soldier : ISoldier
    {
        public string Name { get; }
        public Soldier(string name) => Name = name;
        public void Marsh() => Console.WriteLine($"[Солдат] {Name} марширує");

    }

    class Platoon : ISoldier
    {
        private List<ISoldier> soldiers = new List<ISoldier>();
        public string Name { get; }

        public Platoon(string name) => Name = name;

        public void Marsh()
        {
            Console.WriteLine($"\n[{Name}] містить:");
            foreach (var soldier in soldiers)
            {
                soldier.Marsh();
            }
        }

        public void Add(ISoldier soldier)
        {
            soldiers.Add(soldier);
            Console.WriteLine($"\n[{Name}] отримав підлеглого {soldier.Name}");
        }

        public void Remove(ISoldier soldier)
        {
            soldiers.Remove(soldier);
            Console.WriteLine($"\n[{Name}] втратив підлеглого {soldier.Name}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ISoldier soldier1 = new Soldier("Солдат 1");
            ISoldier soldier2 = new Soldier("Солдат 2");
            ISoldier soldier3 = new Soldier("Солдат 3");

            Platoon alphaPlatoon = new Platoon("Альфа");
            alphaPlatoon.Add(soldier1);
            alphaPlatoon.Add(soldier2);
            alphaPlatoon.Add(soldier3);

            Platoon betaPlatoon = new Platoon("Бета");
            betaPlatoon.Add(new Soldier("Солдат 4"));
            betaPlatoon.Add(new Soldier("Солдат 5"));

            Platoon company = new Platoon("Компанія 1");
            company.Add(alphaPlatoon);
            company.Add(betaPlatoon);

            company.Marsh();
        }
    }
}
