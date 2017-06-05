using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
 
        Int32 Salary { get; set; }
        string Profession { get; set; }
        public Room Room { get; set; }

        public Employee(DateTime birthDate, string name, Int32 salary, string profession) : base(birthDate, name)
        {
            BirthDate = birthDate;
            Name = name;
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return "Name: " + Name + 
                " , BirthDate: " + BirthDate + 
                " , Gender: " + Gender +
                " , salary: " + Salary + 
                " , profession: " + Profession +
                " , room number: " + Room.RoomNumber;
        }

    }
}
