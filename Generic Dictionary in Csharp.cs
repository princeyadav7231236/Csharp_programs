using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "Pyari Doctor");
            dct.Add(2, "Doremon");
            dct.Add(3, "Diwakar Singh");
            dct.Add(4, null);
            dct[5] = "Rani Sahiba";
            try
            {
                dct.Add(2, "Diwakar");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with key = 2 already exists.");
            }

            Dictionary<string, int?> dct2 = new Dictionary<string, int?>() { { "msg1", 1 }, { "msg2", 2 }, { "msg3", 3 } };
            dct2["msg4"] = null;

            foreach (KeyValuePair<string, int?> item in dct2)
            {
                Console.WriteLine("Key : {0}, Value : {1}", item.Key, item.Value);
            }

            string val1 = dct[2];
            string val2 = dct[4];
            Console.WriteLine(val1);   // Doremnon
            Console.WriteLine(val2);   // Null

            dct.Remove(4);
            Console.WriteLine(dct.ContainsKey(4));                 // False
            Console.WriteLine(dct.ContainsValue("Pyari Doctor"));  // True

            Console.ReadLine();
        }
    }
}
