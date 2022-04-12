using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_HashSet_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hst = new HashSet<int>();
            hst.Add(1);
            hst.Add(2);
            hst.Add(2);
            hst.Add(3);
            hst.Add(5);
            hst.Add(4);
            hst.Add(3);
            Console.WriteLine(hst.Count);     // 5

            foreach (int item in hst)
            {
                Console.WriteLine(item);
            }

            HashSet<string> hst2 = new HashSet<string>() { "Hello", "Hello", "Doctor", "Doctor" };
            Console.WriteLine(hst2.Count);        // 2
            Console.WriteLine(hst.Contains(2));   // True
            Console.WriteLine(hst.Contains(6));   // False
            hst.Remove(3);

            Console.ReadLine();
        }
    }
}
