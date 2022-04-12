using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesand_objects
{
    class Details
    {
        public string name;
        public int age;
        public Details(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void GetUserDetails()
        {
            Console.WriteLine("Name : {0}, age : {1}", name, age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Details details = new Details("Shinchan and Pyari Doctor", 17);
            details.GetUserDetails();
            Console.ReadLine();
        }
    }
}
