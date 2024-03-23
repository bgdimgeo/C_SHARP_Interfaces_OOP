using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public  class PlayAround
    {
        private readonly ICollection<int> data; //Abstract collection definitioan, insde the class this is a simple collection
        // we can do antyhign with it
        //readonly means I can define one instance of the object in the constructor, meaning new reference data type in the heap 
        //if we try to create new instance we are going to recieve an error, we remove the read only then we can define new isntance 



        public PlayAround()
        {
            this.data = new List<int>(); // define the type of collection with downcast
        }
        public IReadOnlyCollection<int> Nums => (IReadOnlyCollection<int>)this.data; // property to be readonly
                                                                                     // in order not to be changed ouside 
                                                                                     //If you want to modify you need to use the methods 


        private void AddNumber(int num) 
        {
            this.data.Add(num);
        }


    }
}
