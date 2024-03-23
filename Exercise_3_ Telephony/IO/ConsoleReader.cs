using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.IO
{
    using Telephony.IO.Interfaces;

    internal class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            string text = Console.ReadLine();
            return text;
        }
    }
}
