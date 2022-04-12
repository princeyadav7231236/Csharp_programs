using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class User
    {
        public string name;
        public int age;
        // constructor overloading 
        // default constructor
        public User()
        {
            name = "Diwakar Singh";
            age = 17;
            Console.WriteLine(name + "   " + age);
        }
        //parameterized constructor
        public User(string a, int b)
        {
            name = a;
            age = b;
            Console.WriteLine(name + "   " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            User user1 = new User("shinchan", 17);
            Console.ReadLine();
        }
    }
}
