using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    class user
    {
        public string name;
        public user(string name)
        {
            this.name = name;
        }
        public void GetUserDetails()
        {
            Console.WriteLine("Name : {0}" , name);
            Console.WriteLine("Marks : {0}" , Exam.GetPercentage(this));
        }
    }
    class Exam
    {
        public static double GetPercentage(user u)
        {
            double marks = ((double)470 / 600) * 100;
            return marks;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            user u = new user("Shinchan");
            u.GetUserDetails();
            Console.ReadLine();
        }
    }
}
