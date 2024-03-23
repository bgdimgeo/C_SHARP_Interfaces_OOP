
using System;
using System.Collections.Generic;
using System.Text;

namespace BoarderControl.IO
{
    using Interfaces;
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
