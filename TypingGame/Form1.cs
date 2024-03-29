﻿using System;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Add a random key to the ListBox
            listBox1.Items.Add((Keys)random.Next(65, 90));

            // Ends the game if the amount of characters on screen passes 7
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();

                // Displays a message box to give the option to restart the game.
                if ((MessageBox.Show("Would you like to play again?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If teh user pressed a key that's in the ListBox, remove it
            // and then make the game a little faster
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();

                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;


                // The user pressed a correct key, so update the stats object
                // by calling its Updat() method with the argument true
                stats.Update(true);
            }
            else
            {
                // The user pressed an incrrect key, so update the Stats object
                // by calling its Update() mehtod with the argument false
                stats.Update(false);
            }

            // Update the labels on the StatusStrip
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}
