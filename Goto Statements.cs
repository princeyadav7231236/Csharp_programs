using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 10; a++)
            {
                if (a == 5)
                    goto endloop;
                Console.WriteLine(a);
            }
        endloop: Console.WriteLine("The end");


            // goto statement with endloop in CSharp
            int i = 3, j = 0;
            switch (i)
            {
                case 1:
                    j += 20;
                    Console.WriteLine(j);
                    break;
                case 2:
                    j += 5;
                    goto case 1;
                case 3:
                    j += 30;
                    goto case 2;
                default:
                    Console.WriteLine("Not Known");
                    break;
            }
                







            Console.ReadLine();
        }
    }
}
