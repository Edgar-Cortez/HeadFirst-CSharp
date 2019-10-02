using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page129
{
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            // Checks to see if the requested amount is a positive value and less than total Cash and subtracts the amount from Cash
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            // If they don't have enough funds display message and return 0 as the amount
            else
            {
                MessageBox.Show("I don't have enough cash to give you " + amount, Name + " says...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            // Checks to see if the amount is a positive value and adds the amount to Cash
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            // If zero or negative amount it displays message and return 0 as the amount
            else
            {
                MessageBox.Show(amount + " isn't an amount I'll take", Name + " says...");
                return 0;
            }
        }
    }
}
