using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models
{
    public class Robot : IIdentifiable 
    { 
        private string name;

        public Robot(string name,string ids)
        {
            Name = name;

            Ids = ids;

        }


        public string Ids { get; set; }

        public string Name { get { return this.name; } set { this.name = value; } }


    }
}
