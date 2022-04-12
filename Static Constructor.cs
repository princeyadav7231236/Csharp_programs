using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class user
    {
        static user()
        {
            Console.WriteLine("Static Constructor");
        }
        public user()
        {
            Console.WriteLine("Default Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Both static and derived constructors will invoke
            user u1 = new user();
            // only the derived constructor will invoke
            user u2 = new user();

            Console.ReadLine();
        }
    }
}
