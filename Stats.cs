using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_First_Game_using_Csharp____Hit_the_Keys
{
    class Stats
    {
        public int total = 0;
        public int correct = 0;
        public int missed = 0;
        public int Accuracy = 0;

        public void Update(bool correctkey)
        {
            total++;
            if (!correctkey)
            {
                missed++;
            }
            else
            {
                correct++;
            }
            Accuracy = 100 * correct / (missed + correct);
        }
    }
}
