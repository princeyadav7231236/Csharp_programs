using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    class user
    {
        public string name, location;
        public user(string name, string location)
        {
            this.name = name;
            this.location = location;
        }
        public user(user u)
        {
            name = u.name;
            location = u.location;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            user u = new user("Shinchan", "UP");
            Console.WriteLine(u.name + "  " + u.location);
            user u1 = new user(u);
            Console.WriteLine(u1.name + "  " + u1.location);
            u1.name = "Doctor";
            u1.location = "UP";
            Console.WriteLine(u1.name + "  " + u1.location);
            Console.ReadLine();
        }
    }
}
