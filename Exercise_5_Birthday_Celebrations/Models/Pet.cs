using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models
{
    public class Pet : IBirthday
    {
        private string name;

        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;

        }

        public string Birthday { get; set; }

        public string Name { get { return this.name; } set { this.name = value; } }


    }
}
