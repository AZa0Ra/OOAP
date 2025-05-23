namespace Module4
{
    abstract class RaceAI
    {
        public void ExecuteTurn()
        {
            BuildUnits();
            BuildBuildings();
            Attack();
            Defend();
            Console.WriteLine();
        }
        protected abstract void BuildUnits();
        protected abstract void BuildBuildings();
        protected abstract void Attack();
        protected abstract void Defend();
    }
    class OrcsAI : RaceAI
    {
        protected override void BuildUnits()
        {
            Console.WriteLine("Орки будують потужних воїнів.");
        }
        protected override void BuildBuildings()
        {
            Console.WriteLine("Орки будують просту оборону.");
        }
        protected override void Attack()
        {
            Console.WriteLine("Орки агресивно атакують!");
        }
        protected override void Defend()
        {
            Console.WriteLine("Орки агресивно обороняються.");
        }
    }
    class HumansAI : RaceAI
    {
        protected override void BuildUnits()
        {
            Console.WriteLine("Люди будують воїнів.");
        }
        protected override void BuildBuildings()
        {
            Console.WriteLine("Люди будують стіни та башти.");
        }
        protected override void Attack()
        {
            Console.WriteLine("Люди тактично атакують.");
        }
        protected override void Defend()
        {
            Console.WriteLine("Люди фокусуються на обороні.");
        }
    }

    class WildMonstersAI : RaceAI
    {
        protected override void BuildUnits()
        {
            Console.WriteLine("Дикі монстри появляються купками.");
        }
        protected override void BuildBuildings()
        {
            Console.WriteLine("Дикі монстри не будують будівель.");
        }
        protected override void Attack()
        {
            Console.WriteLine("Дикі монстри дико та відчайдушно атакують.");
        }
        protected override void Defend()
        {
            Console.WriteLine("Дикі монстри слабо обороняються.");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            RaceAI orcs = new OrcsAI();
            RaceAI humans = new HumansAI();
            RaceAI monsters = new WildMonstersAI();

            Console.WriteLine("Хід орків:");
            orcs.ExecuteTurn();

            Console.WriteLine("Хід людей:");
            humans.ExecuteTurn();

            Console.WriteLine("Хід диких монстрів:");
            monsters.ExecuteTurn();
        }
    }
}
