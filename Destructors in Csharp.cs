using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors_in_csharp
{
    class user
    {
        public user()
        {
            Console.WriteLine("An instance of the class created");
        }
        ~user()
        {
            Console.WriteLine("An instance of the class destroyed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            details();
            GC.Collect();
            user u1 = new user();
            Console.ReadLine();
        }
        public static void details()
        {
            user u = new user();
        }
    }
}
