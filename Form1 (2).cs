using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2_program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // this is a comment 
            /*string name = "Diwakar Singh";
            int x = 3;
            x = x * 1245;
            double d = Math.PI;
            MessageBox.Show("The name is " + name + "\nx is " + x + "\nd is " + d);*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 10;
            if (x == 10)
            {
                MessageBox.Show("X must be 10");
            }
            else
            {
                MessageBox.Show("X isn't 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int some_value = 4;
            string name = "John";
            if (some_value == 4 && name == "Rohit")
            {
                MessageBox.Show("X is 3 and name is Rohit");
            }
            MessageBox.Show("This line runs no matter what");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            MessageBox.Show("The answer is " + count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int result = 0;
            int x = 6;
            while (x > 3)
            {
                result = result + x;
                x = x - 1;
            }
            for (int i = 1; i < 3; i++)
            {
                result = result + i;
            }
            MessageBox.Show("The result is " + result);
            MessageBox.Show("The result is " + result);

            int j = 2;
            for (int i = 1; i < 100; i = i * 2)
            {
                MessageBox.Show("the values of i is "+ i);

                j = j - i;
                while (j < 25)
                {
                    j = j + 5;
                }
            }
            MessageBox.Show("The value of j is " + j);

        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* int x = 0;
            string poem = "";           // This program is not running.
            while(x < 4)
            {
                poem = poem + "a";
                if( x < 1)
                {
                    poem = poem + " ";
                }                           
                poem = poem + "n";
                if(x < 1)
                {
                    poem = poem + " oyster";
                    x = x + 2 ;
                }
                if( x == 1)
                {
                    poem = poem + "noys";
                }
                if(x < 1)
                {
                    poem = poem + "oise";
                }
            }
            MessageBox.Show(poem); */
        }
    }
}
