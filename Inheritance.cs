using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class user
    {
        public string name1 = "Shinchan";
        private string name2 = "Pyari Doctor";
        public user()
        {
            Console.WriteLine("Base class constructor");
        }
        public void GetUserInfo()
        {
            Console.WriteLine(name1);
            Console.WriteLine(name2);
        }
    }
    class Details : user
    {
        public int age;
        public Details()
        {
            Console.WriteLine("Derived class Constructor");
        }
        public void GetAge(int age)
        {
            this.age = age;
            Console.WriteLine("The age is : {0}", this.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details();    // Base class constructor
                                          // Derived class Constructor

            d.age = 16;
            d.name1 = "Doctor";
            // compile time error 
            // d.name2 = "Shinchan";
            d.GetUserInfo();              // Doctor
                                          // Pyari Doctor

            d.GetAge(17);                 // The age is : 17

            Console.ReadLine();
        }
    }
}
