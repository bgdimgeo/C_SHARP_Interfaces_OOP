using BoarderControl.IO.Interfaces;
using BoarderControl.Models;
using BoarderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoarderControl.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Start()
        {
            IDList ids = new IDList();
            string command = this.reader.ReadLine();
            while (command != "End") 
            {
                string[] currArgs = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (currArgs.Length > 2)
                {
                    IIdentiable currCitizen = new Citizen(currArgs[0], int.Parse(currArgs[1]), currArgs[2]);
                  
                    ids.Add(currCitizen);
                }
                else 
                {
                    IIdentiable currRobot = new Robot(currArgs[0], currArgs[1]);
                    ids.Add(currRobot);
                }
                command = this.reader.ReadLine();   
            }
            string command2 = this.reader.ReadLine();
           
            foreach (var kvp in ids) 
            {
                if (kvp.Id.Substring(kvp.Id.Length-3).Contains(command2))
                {
                    this.writer.WriteLine(kvp.Id);
                }
            }

        }
    }
}
