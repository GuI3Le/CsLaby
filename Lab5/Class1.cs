using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Person
    {
        private string name;
        private string surname;
        private DateTime birthDate;
        private string gender;

        public Person()
        {
            this.name = string.Empty;
            this.surname = string.Empty;
            this.birthDate = DateTime.MinValue;
            this.gender = string.Empty;
        }
        public Person(string name, string surname, DateTime birthDate, string gender)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
            this.gender = gender;
        }
    }
}
