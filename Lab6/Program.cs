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

            ISoldier soldier1 = new Soldier("Пупкін");
            ISoldier soldier2 = new Soldier("Залупкін");
            ISoldier soldier3 = new Soldier("Хуйкін");

            Platoon alphaPlatoon = new Platoon("Альфа");
            alphaPlatoon.Add(soldier1);
            alphaPlatoon.Add(soldier2);
            alphaPlatoon.Add(soldier3);

            Platoon betaPlatoon = new Platoon("Бета");
            betaPlatoon.Add(new Soldier("Сидоренко"));
            betaPlatoon.Add(new Soldier("Мельник"));

            Platoon company = new Platoon("Компанія 1");
            company.Add(alphaPlatoon);
            company.Add(betaPlatoon);

            company.Marsh();
        }
    }
}
