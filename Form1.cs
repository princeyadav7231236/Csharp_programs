using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive_Management_System
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nector Collector", "Honey Manufacturing" });
            workers[1] = new Worker(new string[] { "Egg Care", "Baby Bee Turtoring" });
            workers[2] = new Worker(new string[] { "Hive Maintenance", "Sting Petrol" });
            workers[3] = new Worker(new string[] { "Nector Collector", "Honey Manufacturing",
            "Egg Care", "Baby Bee Turtoring", "Hive Maintenance", "Sting Petrol"});
            queen = new Queen(workers);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(queen.AssignWork(WorkerBeeJob.Text, (int)Shifts.Value) == false)
                MessageBox.Show("No worker are available to do the job '" + WorkerBeeJob.Text +
                    "'" , "The Queen Bee says ...");
            else
                MessageBox.Show("The job '" + WorkerBeeJob.Text + "' will be done in " + 
                    Shifts.Value + " Shifts", "The Queen Bee says...");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
