using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreItProject.StoreItClasses
{
    public class Customer
    {
        public string Name
        { get; set; }
        public decimal Debt { get; set; }

        public Customer(string name)
        {
            Name = name;
            Debt = 0;
        }
    }
}
