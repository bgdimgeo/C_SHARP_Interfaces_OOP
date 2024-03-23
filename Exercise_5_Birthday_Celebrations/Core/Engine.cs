using BirthdayCelebrations.Core.Interface;
using BirthdayCelebrations.IO;
using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayCelebrations.Core
{
    internal class Engine : IEngine
    {
        private readonly Reader reader;
        private readonly Writer writer;
        public Engine(Reader reader, Writer writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Start()
        {
            List<IBirthday> birthdays = new List<IBirthday>();
            string command = this.reader.ReadLine();
            while (command != "End")
            {
                string[] currArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (currArgs[0] == "Citizen")
                {
                    IBirthday currCitizen = new Citizen(currArgs[1], int.Parse(currArgs[2]), currArgs[3], currArgs[4]);

                    birthdays.Add(currCitizen);
                }
                else if (currArgs[0] == "Robot")
                {
                    //IIdentiable currRobot = new Robot(currArgs[0], currArgs[1]);
                    //ids.Add(currRobot);
                    command = this.reader.ReadLine();
                    continue;
                }
                else if (currArgs[0] == "Pet") 
                {
                    
                   IBirthday currPet = new Pet(currArgs[1],  currArgs[2]);

                   birthdays.Add(currPet);
                    
                }
                    command = this.reader.ReadLine();
            }
            string command2 = this.reader.ReadLine();

            foreach (var kvp in birthdays)
            {
                if (kvp.Birthday.Substring(kvp.Birthday.Length - 4).Contains(command2))
                {
                    this.writer.WriteLine(kvp.Birthday);
                }
            }
        }
    }
}
