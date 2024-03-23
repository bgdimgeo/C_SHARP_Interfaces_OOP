using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models
{
    using Interface;
    internal class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            
            return $"Dialing... {number}";
        }
        
    }
}
