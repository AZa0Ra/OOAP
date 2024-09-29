using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivanov", "Ivan", "Ivanovich",
                new DateTime(2000, 5, 20), "IT", "IT-01", "State-funded", 1000);
            Person person2 = new Person("Petrov", "Petr", "Petrovich",
                new DateTime(1999, 10, 15), "IT", "IT-01", "Self-funded", 1500);
            Person person3 = new Person("Sidorov", "Sidor", "Sidorovich",
                new DateTime(2001, 3, 12), "Law", "LAW-02", "State-funded", 1000);

            Room room1 = new TwoPersonRoom();
            room1.AddPerson(person1);
            room1.AddPerson(person2);
            room1.AddPerson(person3);

            Room room2 = new ThreePersonRoom();
            Room clonedRoom = (Room)room1.Clone();

            Console.WriteLine("\nOriginal TwoPersonRoom:");
            Console.WriteLine(room1.ToString());

            person1 = new Person("Tipov", "Tip", "Tipovich",
new DateTime(2004, 5, 20), "TI", "TI-11", "Self-funded", 500);

            room2.AddPerson(person1);
            room2.AddPerson(person2);
            room2.AddPerson(person3);

            Console.WriteLine("\nOriginal ThreePersonRoom:");
            Console.WriteLine(room2.ToString());

            Console.WriteLine("\nCloned room:");
            Console.WriteLine(clonedRoom.ToString());

            clonedRoom.GenerateReport("RoomReport.txt");
        }
    }
}
