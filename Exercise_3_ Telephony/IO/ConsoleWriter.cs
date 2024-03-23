using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.IO
{
    using Telephony.IO.Interfaces;
    public class ConsoleWriter : IWritter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

    }
}
