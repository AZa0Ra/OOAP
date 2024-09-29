using System;

namespace Lab_3_2
{
    //class Person : IPrototype<Person>
    class Person : ICloneable
    {
        public string Surname { get; set; }

        public string Name { get; set; }
        public string Paronym { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }
        public string StudyType { get; set; }
        public double Rent { get; set; } 

        public Person(string surname, string name, string paronym, DateTime dateOfBirth, string faculty, string group, string studyType, double rent)
        {
            Surname = surname;
            Name = name;
            Paronym = paronym;
            DateOfBirth = dateOfBirth;
            Faculty = faculty;
            Group = group;
            StudyType = studyType;
            Rent = rent;
        }

        //public Person Clone()
        //{
        //    return MemberwiseClone() as Person;
        //}

        public object Clone()
        {
            return MemberwiseClone() as Person;
        }
    }
}
