using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_SortedList_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> slist = new SortedList<int, string>();
            slist.Add(001, "Pyari Doctor");
            slist.Add(002, "Doctor");
            slist.Add(003, "Doremon");
            slist.Add(004, "Diwakar");
            slist.Add(005, null);
            slist[6] = "Rani Sahiba";
            try
            {
                slist.Add(2, "Shinchan");
            }
            catch (Exception e)
            {
                Console.WriteLine("An element with key = 2, already exist.");
            }
            SortedList<string, int?> slst2 = new SortedList<string, int?>() { { "msg1", 1 }, { "msg2", 2 }, { "msg3", 3 } };
            foreach (KeyValuePair<string, int?> item in slst2)
            {
                Console.WriteLine("Key : {0}, Vlaue : {1}", item.Key, item.Value);
            }

            string val1 = slist[2];
            string val2 = slist.Values[2];
            int val3 = slist.Keys[2];
            Console.WriteLine(val1);   // Doctor
            Console.WriteLine(val2);   // Doremon
            Console.WriteLine(val3);   // 3

            for (int i = 0; i < slist.Count; i++)
            {
                Console.WriteLine("Key : {0}, Value : {1}", slist.Keys[i], slist.Values[i]);
            }

            slist.Remove(5);
            slist.RemoveAt(3);
            Console.WriteLine(slist.ContainsValue("Doremon"));  // True
            Console.WriteLine(slist.ContainsKey(5));            // False

            Console.ReadLine();
        }
    }
}
