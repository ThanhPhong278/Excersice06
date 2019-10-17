using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phongvo
{
    public class Account
    {
        int money;
        public Account(int amount)
        {
            money = amount;
        }

        public void Deposit(int amount)
        {
            money -= amount;
        }

        public void Withdraw(int amount)
        {
            money += amount;
        }

        public int Balance()
        {
            return money;
        }

    }
}
