using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_Inheritance
{
    class A
    {
        public string name1;
        public void getName1()
        {
            Console.WriteLine(name1);
        }
    }
    class B : A
    {
        public string name2;
        public void getName2()
        {
            Console.WriteLine(name2);
        }
    }
    class C : B
    {
        public string name3;
        public void getName3()
        {
            Console.WriteLine(name3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.name1 = "Pyari Doctor";
            c.name2 = "  Shinchan";
            c.name3 = " Rani Sahiba";
            c.getName1();     // Pyari Doctor
            c.getName2();     //   Shinchan
            c.getName3();     //  Rani Sahiba

            // Multiple inheritance is not supported in C#
            /*public class A { }
            public class B { }
            public class C : A, B { }*/

            Console.ReadLine();
        }
    }
}
