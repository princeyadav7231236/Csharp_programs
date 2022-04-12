using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_chaining
{
    class details
    {
        public details()
        {
            Console.Write("Hello ");
        }
        public details(string str) : this()
        {
            Console.Write(str);
        }
        public details(string a , String b): this("Meri ")
        {
            Console.WriteLine(a + "" + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            details msg = new details("Pyari ", "Doctor");
            Console.ReadLine();
        }
    }
}
