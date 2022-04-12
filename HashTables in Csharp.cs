using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable htbl = new Hashtable();
            htbl.Add("Name ", "Doremon");
            htbl.Add("Msg", "Meri Pyari Doctor");
            htbl.Add(1, 20.8478);
            htbl.Add(2, null) ;

            // another way to add elements 
            htbl[3] = "Doremon and Pyari Doctor";

            // Add method will throw an exception if key already, exists in the hashTable.
            try
            {
                htbl.Add(2, 4548);
            }
            catch (Exception e)
            {
                Console.WriteLine("An element with key = 2, already exists.");
            }

            // Accessing elements from the hashtable
            string msg = (string)htbl[3];
            Console.WriteLine("msg :--> {0}", msg);
            double num = (double)htbl[1];
            Console.WriteLine("num :--> {0}", num);

            // Removing elements from the hashtable
            htbl.Remove(1);
            htbl.Remove(2);

            // Checking if elements exists in the hashtable or not.
            Console.WriteLine(htbl.Contains(4));
            Console.WriteLine(htbl.Contains("Msg"));

            // Accessing all elements from the hashtable. Here the output will be sorted by the keys HashCode
            Console.WriteLine("Accessing all the elements using DictionaryEntry ");
            foreach (DictionaryEntry item in htbl)
            {
                Console.WriteLine(item.Key  + " :--> " +  item.Value);
            }
            Console.WriteLine("Accessing all the keys and HashCode of all the keys of the hashtable");
            foreach (var item in htbl.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(item + " :--> " + item.GetHashCode());
            }
            Console.WriteLine("Accessing all the values of the hashtable");
            foreach (var item in htbl.Values)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
