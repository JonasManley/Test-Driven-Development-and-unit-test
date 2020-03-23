using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Driven_Development
{
    class Bank : 
    {
        private string cvr;
        private string name;
        private Customer customer;
        private Account account;
        private List<Account> accounts;

        public Bank(string cvr, string name)
        {
            this.cvr = cvr;
            this.name = name;
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }

        public Account GetAccount(int id)
        {
            foreach (var item in accounts)
            {
                if(item.Number == id)
                {   
                    return item;
                }
            }
            return null; 
        }   
    }
}
