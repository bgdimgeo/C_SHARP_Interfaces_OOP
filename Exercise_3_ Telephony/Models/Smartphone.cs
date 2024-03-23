using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models
{
    using Interface;
    internal class Smartphone : ICallable, IBrowseble
    {
        public string BrowseURL(string url)
        {
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            return $"Calling... {number}";
        }
    }
}
