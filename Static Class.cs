using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_classes
{
    class User
    {
        public static string collegeName;
        public static String course;

        static User()
        {
            collegeName = "xyz";
            course = "abc";
        }

        public static void displayUserDetails()
        {
            Console.WriteLine(collegeName);
            Console.WriteLine(course);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User.displayUserDetails();
            Console.ReadLine();
        }
    }
}
