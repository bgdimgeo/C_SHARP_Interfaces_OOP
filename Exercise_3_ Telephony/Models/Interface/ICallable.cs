using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models.Interface
{
    internal interface ICallable
    {
        string Call(string number);
    }
}
