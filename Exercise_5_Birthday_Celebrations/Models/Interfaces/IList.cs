using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models.Interfaces
{
    public interface IList<T> :IEnumerable
    {
        public List<T> List { get; set; }
        public void Add(T item);

    }
}
