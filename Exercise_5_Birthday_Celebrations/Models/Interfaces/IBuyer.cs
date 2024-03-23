using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models.Interfaces
{
    public interface IBuyer: IPerson
    {

        public int Food { get; set; }

        public void BuyFood();
    }
}
