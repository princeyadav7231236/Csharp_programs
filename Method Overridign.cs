using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class A
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("A class Method");
        }
    }
    class B : A
    {
        public override void GetInfo()
        {
            Console.WriteLine("B class Method");
        }
    }
    class C : B
    {
        public override void GetInfo()
        {
            Console.WriteLine("C class Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.GetInfo();         // A class Method
            B b = new B();
            b.GetInfo();         // B class Method
            C c = new C();
            c.GetInfo();         // C class Method

            Console.ReadLine(); 
        }
    }
}
