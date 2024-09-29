using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_3_2
{
    public interface IPrototype<T>
    {
        T Clone();
    }
    //abstract class Room : IPrototype<Room>
    abstract class Room : ICloneable
    {

        private int _roomType;

        public int RoomType
        {
            get { return _roomType; }
            set
            {
                if (value == 2 || value == 3)
                    _roomType = value;
                else
                    Console.WriteLine("Room type must be either 2 or 3");
            }
        }

        private List<Person> _people = new List<Person>();

        public void AddPerson(Person person)
        {
            if (_people.Count < _roomType)
            {
                _people.Add(person);
                Console.WriteLine($"{person.Surname} has been added");
            }
            else
            {
                Console.WriteLine($"The room is full ({RoomType})");
            }
        }

        public List<Person> GetPeople()
        {
            return _people;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Room type: {_roomType} rooms");
            stringBuilder.AppendLine($"Number of residents: {_people.Count}");
            stringBuilder.AppendLine("Residents:");
            foreach (var person in _people)
            {
                stringBuilder.AppendLine($"{person.Surname} {person.Name} {person.Paronym}," +
                    $" Born: {person.DateOfBirth.ToShortDateString()}," +
                    $" Faculty: {person.Faculty}, Group: {person.Group}," +
                    $" Study Type: {person.StudyType}, Rent: {person.Rent} UAH");
            }
            return stringBuilder.ToString();
        }

        public void GenerateReport(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Room type: {_roomType} rooms");
                writer.WriteLine($"Number of residents: {_people.Count}");
                writer.WriteLine("Residents:");
                foreach (var person in _people)
                {
                    writer.WriteLine($"{person.Surname} {person.Name} {person.Paronym}," +
                    $" Born: {person.DateOfBirth.ToShortDateString()}," +
                    $" Faculty: {person.Faculty}, Group: {person.Group}," +
                    $" Study Type: {person.StudyType}, Rent: {person.Rent} UAH");
                }
                writer.WriteLine(new string('-', 110));
            }
        }

        //public virtual Room Clone()
        //{
        //    Room clone = (Room)MemberwiseClone();
        //    clone._people = new List<Person>();
        //    foreach (var person in _people)
        //    {
        //        clone._people.Add(person.Clone());
        //    }
        //    return clone;
        //}

        public object Clone()
        {
            Room clone = (Room)MemberwiseClone();
            clone._people = new List<Person>();
            foreach (var person in _people)
            {
                clone._people.Add((Person)person.Clone());
            }
            return clone;
        }
    }
    class TwoPersonRoom : Room
    {
        public TwoPersonRoom()
        {
            RoomType = 2; 
        }
    }

    class ThreePersonRoom : Room
    {
        public ThreePersonRoom()
        {
            RoomType = 3; 
        }
    }
}
