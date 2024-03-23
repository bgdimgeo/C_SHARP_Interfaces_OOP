using System;
using System.Collections.Generic;
using System.Text;

namespace BoarderControl.Models
{
    using Interfaces;
    public class Robot:IIdentiable
    {
        private string model;

        public Robot( string model, string id)
        {
            this.model = model;
            Id = id;
        }

        public string Id { get ; set; }
    }
}
