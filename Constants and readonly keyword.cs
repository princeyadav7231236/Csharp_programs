using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constant
{
    class user
    {
        public readonly string name = "Meri Pyari Doctor";
        public readonly string location;
        public readonly int age;

        public user()
        {
            location = "UP";
            age = 17;
            age = 18;  // new age 
        }
        public void details()
        {
            /*location = "Uttar Pradesh";     Compile time error */
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Constant keyword
            const int number = 001;
            Console.WriteLine(number);
            /*number = 002;    this line will give you compile time error as you are trying to modify the constant value */

            // Readonly Keyword
            user u = new user();
            /*location = "Uttar Pradesh";     Compile time error */
            Console.WriteLine(u.name + "  " + u.location + "  " + u.age);
            Console.ReadLine();
        }
    }
}
