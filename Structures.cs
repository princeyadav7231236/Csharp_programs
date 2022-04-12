using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct user
    {
        public string name;
        public int age;
        // public string location = "UP"; // it won't allow us to initialize field with values unless they are declared constant or static.
        public const int adm_no = 001;
        /*public user()
        {
            name = "Shinchan";     // it won't allow us to create default constructors, we can create parameterized constructors.
        }*/

        public user(string name , int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            user u = new user("Pyari Doctor", 17);
            Console.WriteLine(u.name + "  " + u.age);
            u.name = "Shinchan";
            Console.WriteLine(u.name);
            Console.ReadLine();
        }
    }
}
