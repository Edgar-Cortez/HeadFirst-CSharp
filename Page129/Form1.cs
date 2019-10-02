using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page129
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joeCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();

            // This is instantiating another Guy object not related to the ones on line 15-16
            //Guy joe = new Guy();
            //Guy bob = new Guy();

            // You want to use the ones created already on line 15-16 and add the values for Name and Cash
            // ****There is a better way to insert the values****
            // ****See Line 45-46****
            //joe = new Guy();
            //joe.Name = "Joe"; 
            //joe.Cash = 50;
            //
            //bob = new Guy();
            //bob.Name = "Bob";
            //bob.Cash = 100;

            joe = new Guy() { Name = "Joe", Cash = 50 };
            bob = new Guy() { Name = "Bob", Cash = 100 };

            UpdateForm();
        }

        private void JoeButton_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void BobButton_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void JoeGivesToBob_Click(object sender, EventArgs e)
        {
            //Wrong
            //joe.GiveCash(10);
            //bob.ReceiveCash(10);

            //Need to make sure the result is being passed as a parameter properly
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void BobGivesToJoe_Click(object sender, EventArgs e)
        {
            //Wrong
            //bob.GiveCash(5);
            //joe.ReceiveCash(5);

            //Need to make sure the result is being passed as a parameter properly
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
