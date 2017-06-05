using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public enum Gender
    {
        Male,
        Female
    };

    class Person
    {

        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public Person(DateTime birthDate, string name)
        {
            BirthDate = birthDate;
            Name = name;
        }

        public override string ToString()
        {
            return "Name: " + Name + " , BirthDate: " + BirthDate + " , Gender: " + Gender;
        }

        static void Main(string[] args)
        {
            DateTime yearOfBirth = new DateTime(2010, 01, 01);
            Person bela = new Person(yearOfBirth, "Béla");
            bela.Gender = Gender.Male;
            Console.WriteLine(bela);

            Employee eufrozina = new Employee(yearOfBirth, "frozi", 21000, "zabhegyező");
            eufrozina.Gender = Gender.Female;
            eufrozina.Room = new Room(1);
            Console.WriteLine(eufrozina);

            Console.ReadKey();
        }
    }
}
