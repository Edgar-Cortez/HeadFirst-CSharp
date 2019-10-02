using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page127
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";

            Echo e1 = new Echo();
            Echo e2 = new Echo();
            
            int x = 0;
            while(x < 4)
            //while(x < 5)                      //WRONG
            {
                result = result + e1.Hello() + "\n";
                e1.Count = e1.Count + 1;        //CORRECT

                if (x == 3)                     //CORRECT
                {
                    e2.Count = e2.Count + 1;
                }

                if (x > 0)
                //if ( x == 4)                 //WRONG 
                {
                    e2.Count = e2.Count + e1.Count;
                }

                x = x + 1;
            }
            MessageBox.Show(result + "Count: " + e2.Count);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

    class Echo
    {
        public int Count = 0;
        public string Hello()
        {
            return "helloooooo...";
        }
    }
}

