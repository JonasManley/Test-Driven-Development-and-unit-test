using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Driven_Development
{
    public class Account
    {
        private int number;
        private double money;
        private Customer customer;
        private Bank bank;


        public Account(int number, double money)
        {
            this.number = number;
            this.money = money;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        //Not used atm. 
        public double getBalance()
        {
            return money;
        }

        public void Transfer(double money, Account targetAccount)
        {
            if(money < 0)
            {
                throw new ArgumentException("Amount is negative");
            }
            targetAccount.money += money;
            money -= money;
        }

    }
}
