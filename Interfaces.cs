using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_Csharp
{
    interface Iuser
    {
        void getName(string a, string b);        
    }
    interface Ilocation
    {
        void getLocation(string locOfA, string locOfB);
    }
    class User:Iuser, Ilocation
    {
        public void getName (string a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public void getLocation(string locA, string locB)
        {
            Console.WriteLine(locA);
            Console.WriteLine(locB);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output of Iuser interface");
            Iuser u = new User();
            u.getName("Pyari Doctor", "Doremon");
            Console.WriteLine("Output of Ilocation interface");
            Ilocation loc = new User();
            loc.getLocation("UP", "UP");
            Console.WriteLine("Output of User class");
            User user = new User();
            user.getName("Rani Sahiba", "Shinchan");
            user.getLocation("UP", "UP");

            Console.ReadLine();
        }
    }
}
