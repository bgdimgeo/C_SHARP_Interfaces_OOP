using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IIdentifiable, IBirthday,IBuyer,IPerson
    {
        private string name;
        private int age;
        private string id;
        private int birthday;
        private string food;



        public Citizen(string name, int age,  string ids, string birthday)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
            Ids = ids;

        }

        public string Birthday { get; set; }
        public string Ids { get ; set ; }

        public int Age { get { return this.age; } set { this.age = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }

        public int Food { get ; set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
