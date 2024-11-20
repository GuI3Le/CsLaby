using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Person
    {
        public string name;
        public string lastname;
        public DateTime birthDate;
        public string gender;

        public Person()
        {
            this.name = string.Empty;
            this.lastname = string.Empty;
            this.birthDate = DateTime.MinValue;
            this.gender = string.Empty;
        }
        public Person(string name, string surname, DateTime birthDate, string gender)
        {
            this.name = name;
            this.lastname = surname;
            this.birthDate = birthDate;
            this.gender = gender;
        }
    }
}
