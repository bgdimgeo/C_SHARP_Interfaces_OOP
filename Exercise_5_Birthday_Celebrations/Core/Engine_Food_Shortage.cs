using BirthdayCelebrations.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations.IO;
using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using System.Linq;

namespace BirthdayCelebrations.Core
{
    internal class EngineFoodShortage : IEngine
    {
        private readonly Reader reader;
        private readonly Writer writer;

        public EngineFoodShortage(Reader reader, Writer writer)
        {
            this.reader = reader;
            this.writer = writer;
        }



        public void Start()
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int loops = int.Parse(this.reader.ReadLine());
            for (int i = 0; i < loops; i++)
            {
                string command1 = Console.ReadLine();
                string[] currArgs = command1.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (currArgs.Length == 4)
                {
                    IBuyer currCitizen = new Citizen(currArgs[0], int.Parse(currArgs[1]), currArgs[2], currArgs[3]);
                    buyers.Add(currCitizen);
                }
                else
                {
                    IBuyer currRebel = new Rebel(currArgs[0], int.Parse(currArgs[1]), currArgs[2]);
                    buyers.Add(currRebel);
                }
            }
            string command = Console.ReadLine();
            while (command != "End") 
            {
                foreach (var buyer in buyers.Where(n => n.Name == command)) 
                {
                    buyer.BuyFood();
                }
                command = Console.ReadLine();
            }
            int food = 0;
            foreach (var buyer in buyers)
            {
                food += buyer.Food;
            }
            this.writer.WriteLine(food.ToString());
            //while (coomand != "End")
            //{
            //    string[] currArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    if (currArgs[0] == "Citizen")
            //    {
            //        IBirthday currCitizen = new Citizen(currArgs[1], int.Parse(currArgs[2]), currArgs[3], currArgs[4]);

            //        birthdays.Add(currCitizen);
            //    }
            //    else if (currArgs[0] == "Robot")
            //    {
            //        //IIdentiable currRobot = new Robot(currArgs[0], currArgs[1]);
            //        //ids.Add(currRobot);
            //        command = this.reader.ReadLine();
            //        continue;
            //    }
            //    else if (currArgs[0] == "Pet")
            //    {

            //        IBirthday currPet = new Pet(currArgs[1], currArgs[2]);

            //        birthdays.Add(currPet);

            //    }
            //    command = this.reader.ReadLine();
            //}
            //string command2 = this.reader.ReadLine();

            //foreach (var kvp in birthdays)
            //{
            //    if (kvp.Birthday.Substring(kvp.Birthday.Length - 4).Contains(command2))
            //    {
            //        this.writer.WriteLine(kvp.Birthday);
            //    }
            //}
        }
    }
}
