using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Driven_Development
{
    public class Customer
    {
        private string cpr;
        private string name;

        public Customer(string cpr, string name)
        {
            this.cpr = cpr;
            this.name = name;
        }
    }
}
