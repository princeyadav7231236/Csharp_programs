using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class info
    {
        public abstract void getInfo(string a, string b);
    }
    public class User: info
    {
        public override void getInfo(string a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.getInfo("Pyari Doctor", "Doremon");
            Console.ReadLine();
        }
    }
}
