using System;
using System.Collections.Generic;
using System.Text;

namespace BoarderControl.Models
{
    using Interfaces;
    using System.Collections;

    internal class IDList : IEnumerable<IIdentiable>
    {
        private List<IIdentiable> ids;
        public IDList()
        {
            this.ids = new List<IIdentiable>();
        }
        public IDList(params IIdentiable[] ids)
        {
            this.ids = new List<IIdentiable>(ids);
        }

        public void Add(IIdentiable id) 
        {
            ids.Add(id);
        }

        public bool Remove(IIdentiable id)
        {
            return ids.Remove(id);

        }
        public List<IIdentiable> Ids
        {
            get
            {
                return this.ids;
            }
            set
            {
                this.ids = value;
            }
        }

        public IEnumerator<IIdentiable> GetEnumerator()
        {
            //var bookList = this.books.OrderBy(b => b).ToList();
            //this.books.Sort();
            //return new LibraryIterator(this.books); //Soliton for problem 2 LAB
            for (int i = 0; i < this.ids.Count; i++) // Solution for problem 3 Lab
            {
                yield return this.ids[i];
            }
        }

  

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
