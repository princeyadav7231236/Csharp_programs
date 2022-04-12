using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Keyword
{
    class Bclass
    {
        public virtual string Name
        {
            get;
            set;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Base Class Method");
        }
    }
    class DClass : Bclass
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("No Value");
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine("Derived class Method");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DClass d = new DClass();
            d.GetInfo();                             // Derived class Method
            Bclass b = new Bclass();
            b.GetInfo();                             // Base Class Method
            d.Name = string.Empty;
            Console.WriteLine(d.Name);               // No Value
            d.Name = "Shinchan and Pyari Doctor";
            Console.WriteLine(d.Name);               // Shinchan and Pyari Doctor

            Console.ReadLine();
        }
    }
}
