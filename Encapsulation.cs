using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class user
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            user u = new user();
            // set accessor will invoke
            u.Name = "Pyari Doctor and Shinchan";
            // get accessor will invoke
            Console.WriteLine(u.Name);  // Pyari Doctor and Shinchan

            Console.ReadLine();
        }
    }
}
