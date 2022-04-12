using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_s_Cows
{
    public partial class Form1 : Form
    {
        Farmer MyFarmer;
        public Form1()
        {
            InitializeComponent();
            MyFarmer = new Farmer() { NumberOfCows = 15 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows", MyFarmer.BagsOfFeed, MyFarmer.NumberOfCows);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MyFarmer.NumberOfCows = (int)numericUpDown1.Value;
        }
    }
}
