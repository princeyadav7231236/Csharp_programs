using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_First_Game_using_Csharp____Hit_the_Keys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Random random = new Random();
        Stats stats = new Stats();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Add a Random key to the list box
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if(listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /* If the user presses the key that's in the list box, remove it and then
             * make the game a little faster. */
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
                DifficultyProgressBar.Value = 800 - timer1.Interval;

                /* The user pressed the correct keys, so update the stats object 
                 * by calling its update() method with the argument true stats.update(true);   */
                stats.Update(true);
            }
            else
            {
                /*  The user pressed a incorrect key, so update the stats object by calling its
                 *  update() method with the argument false */
                stats.Update(false);
            }
            // Update the labels of the status strips
            CorrectLabel1.Text = "Correct : " + stats.correct;
            MissedLabel.Text = "Missed : " + stats.missed;
            TotalLabel.Text = "Total : " + stats.total;
            AccuracyLabel.Text = "Accuraacy : " + stats.Accuracy + "%";
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}
