using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page151
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;

        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int) numericUpDown1.Value;
            endingMileage = (int) numericUpDown2.Value;


            if(startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                amountOwedValueLabel.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage","Cannot Calculate Mileage");
            }
        }

        private void DisplayMilesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
