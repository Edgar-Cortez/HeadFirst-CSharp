using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page146
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            //Casted the decimal type into an int type.
            //If you don't do this the compiler will yell at you for being stupid.
            int myIntVlaue = (int) myDecimalValue;

            MessageBox.Show("The myIntValue is " + myIntVlaue);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            bool myBool = (bool)myDouble;           //Won't convert
            string myString = "false";
            myBool = (bool)myString;                //Won't convert
            myString = (string)myInt;               //Won't convert
            myString = myInt.ToString();
            myBool = (bool)myByte;                  //Won't convert
            myByte = (byte)myBool;                  //Won't convert
            short myShort = (short)myInt;
            char myChar = 'x';
            myString = (string)myChar;              //Won't convert
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;
        }
    }
}
