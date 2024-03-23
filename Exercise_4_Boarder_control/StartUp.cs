
using System;

namespace BoarderControl
{
    using BoarderControl.Core;
    using BoarderControl.IO;
    using BoarderControl.IO.Interfaces;
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();

            IEngine engine = new Engine(reader, writer);
            engine.Start();
        }
    }
}
