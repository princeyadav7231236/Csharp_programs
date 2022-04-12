using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("Shinchan", "UP");
            u.GetUserDetails();
            Console.ReadLine();
        }
    }
}
