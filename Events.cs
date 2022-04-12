using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_in_Csharp
{
    class math
    {
        public delegate void SampleDelegate();
        public event SampleDelegate SampleEvent;

        public void add(int a, int b)
        {
            if(SampleEvent != null)
            {
                SampleEvent();
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
        public void sub(int a, int b)
        {
            if(SampleEvent != null)
            {
                SampleEvent();
                Console.WriteLine(a - b);
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
    }
    class operation
    {
        math m;
        public int a { get; set; }
        public int b { get; set; }
        public operation (int a, int b)
        {
            m = new math();
            // subscribe to sampleEvent event
            m.SampleEvent += SampleEventHandler;
            this.a = a;
            this.b = b;
        }
        // Sample Event Handler
        public void SampleEventHandler()
        {
            Console.WriteLine("Sample EventHandler : calling method");
        }
        public void addOperation()
        {
            m.add(a, b);
        }
        public void subOperation()
        {
            m.sub(a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            operation op = new operation(55, 45);
            op.addOperation();    // Sample EventHandler : calling method
                                  // 100

            op.subOperation();    // Sample EventHandler : calling method
                                  // 10


            Console.ReadLine();
        }
    }
}
