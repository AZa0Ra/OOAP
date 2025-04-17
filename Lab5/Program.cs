using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class Weapon
    {
        public virtual string Description { get; set; }
        public virtual int Range { get; set; }
        public virtual int Power { get; set; }
        public virtual int Weight { get; set; }
        public virtual double MaxWeight { get; set; } 

        public abstract double Cost();
        public override string ToString()
        {
            return Description + ": " + Cost() + "$";
        }
    }

    public class AutoRifle : Weapon
    {
        public AutoRifle()
        {
            Description = "AutoRifle";
            Range = 30;
            Power = 40;
            Weight = 5;
            MaxWeight = 8; 
        }

        public override double Cost()
        {
            return 99.99;
        }
    }

    public class Pistol : Weapon
    {
        public Pistol()
        {
            Description = "Pistol";
            Range = 15;
            Power = 20;
            Weight = 2;
            MaxWeight = 4; 
        }

        public override double Cost()
        {
            return 39.99;
        }
    }

    public class Rifle : Weapon
    {
        public Rifle()
        {
            Description = "Rifle";
            Range = 50;
            Power = 60;
            Weight = 4;
            MaxWeight = 8; 
        }

        public override double Cost()
        {
            return 69.99;
        }
    }

    public abstract class AttachmentDecorator : Weapon
    {
        public Weapon weapon;
        public abstract override string Description { get; set; }
        public abstract override double Cost();
    }

    public class Silencer : AttachmentDecorator
    {
        public Silencer(Weapon weapon)
        {
            this.weapon = weapon;
            Weight = weapon.Weight + 1;
            MaxWeight = weapon.MaxWeight;
        }
        public override string Description { get => weapon.Description + ", Silencer"; set { } }

        public override double Cost()
        {
            return (weapon.Cost() + 29.99);
        }
    }

    public class Sight : AttachmentDecorator
    {
        public Sight(Weapon weapon)
        {
            this.weapon = weapon;
            Weight = weapon.Weight + 1;
            MaxWeight = weapon.MaxWeight;
        }
        public override string Description { get => weapon.Description + ", Sight"; set { } }

        public override double Cost()
        {
            return (weapon.Cost() + 19.99);
        }
    }

    public class Grip : AttachmentDecorator
    {
        public Grip(Weapon weapon)
        {
            this.weapon = weapon;
            Weight = weapon.Weight + 1;
            MaxWeight = weapon.MaxWeight;
        }
        public override string Description { get => weapon.Description + ", Grip"; set { } }

        public override double Cost()
        {
            return (weapon.Cost() + 24.99);
        }
    }

    public class WeaponFacade
    {
        public List<Weapon> arsenal = new List<Weapon>(); 
        public Weapon weapon;

        public void ChooseWeapon()
        {
            Console.Clear();
            Console.WriteLine("Оберіти зброю:\n" +
                "1. Штурмова винтівка\n" +
                "2. Пістолет\n" +
                "3. Винтівка\n" +
                "4. Переглянути арсенал\n" +
                "Інше - Вихід");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": { weapon = new AutoRifle(); break; };
                case "2": { weapon = new Pistol(); break; };
                case "3": { weapon = new Rifle(); break; };
                case "4": { PrintArsenal(); return; };
                default: { Console.WriteLine("Бувай!"); return; }
            }
            Console.Clear();
            ChooseAttachment();
        }

        public void ChooseAttachment()
        {
            Console.WriteLine("Оберіти аксесуар:\n" +
                "1. Приціл\n" +
                "2. Глушник\n" +
                "3. Рукоядка\n" +
                "4. Завершити вибір\n" +
                "Інше - Вихід");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": { weapon = new Sight(weapon); break; };
                case "2": { weapon = new Silencer(weapon); break; };
                case "3": { weapon = new Grip(weapon); break; };
                case "4": { CheckWeapon(); return; }
                //default: { Console.WriteLine("Бувай!"); return; }
                default: {  break; }
            }

            if (weapon.Weight > weapon.MaxWeight)
            {
                Console.Clear();
                Console.WriteLine("Вага комплекту перевищує допустиму!");
                return;
                //ChooseWeapon();
            }


            Console.Clear();
            Console.WriteLine("Бажаєте ще аксесуар? " +
                "\n1. Так " +
                "\nВсе інше - Ні");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                ChooseAttachment();
            }
            else
            {
                CheckWeapon();
            }
        }

        public void CheckWeapon()
        {
            if (weapon.Weight > weapon.MaxWeight)
            {
                Console.WriteLine("Вага комплекту перевищує допустиму!");
                return; 
            }
            else
            {
                
                arsenal.Add(weapon); 
                Console.WriteLine("Комплект успішно додано в арсенал!");
            }
            Console.Clear();
            ChooseWeapon();
        }

        public void PrintArsenal()
        {
            Console.Clear();
            if (arsenal.Count > 0)
            {
                Console.WriteLine("Арсенал: ");
                foreach (var item in arsenal)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Арсенал порожній.");
            }

            FindMostExpensiveWeapon();
        }

        public void FindMostExpensiveWeapon()
        {
            var mostExpensive = arsenal.OrderByDescending(w => w.Cost()).FirstOrDefault();
            if (mostExpensive != null)
            {
                Console.WriteLine("\nНайдорожчий комплект в арсеналі:");
                Console.WriteLine(mostExpensive.Description + ": " + mostExpensive.Cost() + "$");
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            WeaponFacade weaponFacade = new WeaponFacade();
            weaponFacade.ChooseWeapon();
        }
    }
}
