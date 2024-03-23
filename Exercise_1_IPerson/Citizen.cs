using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson
    {

        //No validation -> use auto-properties

        public string Name { get ; set; }
        public int Age { get; set; }

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Sleep() 
        {
            return "Zzzzz.....";
        }



    }
}
