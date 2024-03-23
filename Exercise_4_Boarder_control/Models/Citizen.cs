using System;
using System.Collections.Generic;
using System.Text;

namespace BoarderControl.Models
{
    using Interfaces;
    public class Citizen : IIdentiable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            Id = id;
        }

        public string Id { get ; set ; }
    }
}
