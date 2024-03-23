using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.IO.Interfaces
{
    public interface IWritter
    {
        void Write(string text);

        void WriteLine(string text);
    }
}
