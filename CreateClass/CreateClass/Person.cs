using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        enum Gender
        {
            Male,
            Female
        };

        DateTime birthDate;
        String name;
        Gender gender;

        public Person(DateTime birthDate, String name)
        {
            this.birthDate = birthDate;
            this.name = name;
        }

        public void setGender(string gender)
        {
            if (gender == "male")
            {
                this.gender = Gender.Male;
            } else if (gender == "female")
            {
                this.gender = Gender.Female;
            } else
            {
                Console.WriteLine("Unsupported gender type. Please choose valid gender.");
            }
        }

        public override string ToString()
        {
            return "Name: " + this.name + " , BirthDate: " + this.birthDate + " , Gender: " + this.gender;
        }

        static void Main(string[] args)
        {
            DateTime yearOfBirth = new DateTime(2010, 01, 01);
            Person bela = new Person(yearOfBirth, "Béla");
            bela.setGender("male");
            Console.WriteLine(bela);

            Console.ReadKey();
        }
    }
}
