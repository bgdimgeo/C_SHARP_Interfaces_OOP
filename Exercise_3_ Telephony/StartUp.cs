using System;


namespace Telephony
{
    using Telephony.Core;
    using Telephony.IO;
    using Telephony.IO.Interfaces;
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWritter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Start();
        }
    }
}
