using BirthdayCelebrations.Core;
using BirthdayCelebrations.IO;
using System;

namespace Exercise_5_Birthday_Celebrations
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            Writer writer = new Writer();

            //Engine engine = new Engine(reader,writer);
            //engine.Start();
            EngineFoodShortage engine = new EngineFoodShortage(reader, writer);
            engine.Start();
        }
    }
}
