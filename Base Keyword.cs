using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword
{
    public class Bclass
    {
        public Bclass()
        {
            Console.WriteLine("Base class Default Constructor");
        }
        public Bclass(string a , string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public string name = "Pyari Doctor and Shinchan";
        public int age = 17;
        public virtual void GetInfo()
        {
            Console.WriteLine("The age is : {0}", age);
        }
    }
    public class Dclass : Bclass
    {
        public Dclass() : base()
        {
            Console.WriteLine("Derived Class default Constructor");
        }
        public Dclass(string x, string y) : base(x, y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(base.name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dclass d1 = new Dclass();                      // Base class Default Constructor
                                                           // Derived Class default Constructor
                                                           
            d1.GetInfo();                                  // The age is : 17
                                                           // Pyari Doctor and Shinchan

            Dclass d2 = new Dclass("Shinchan", "Doctor");  // Shinchan
                                                           //Doctor
                                                           //Shinchan
                                                           //Doctor

            d2.GetInfo();                                  // The age is : 17
                                                           // Pyari Doctor and Shinchan

            Console.ReadLine();
        }
    }
}
