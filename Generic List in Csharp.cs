using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Lists_in_Csharp
{
    public class user
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 45, 80};
            lst.Add(55);
            lst.Add(55);
            Console.WriteLine(lst.Count);     // 6
            Console.WriteLine(lst.Capacity);  // 8

            List<int> lst2 = new List<int>();
            lst2.AddRange(lst);
            Console.WriteLine(lst2.Count);     // 6
            Console.WriteLine(lst2.Capacity);  // 6

            Console.WriteLine("Accessing all the elements of the the list using foreach loop :- ");
            foreach (int item in lst2)
            {
                Console.WriteLine(item);
            }

            List<user> u = new List<user>() { new user { ID = 001, Name = "Pyari Doctor", Location = "UP" },
            new user{ ID = 002 , Location = "UP" ,Name = "Shinchan"} };
            u.Add(new user { ID = 003, Name = "Rani Sahiba", Location = "UP" });

            Console.WriteLine("The number of elements present in the user list :- ");
            Console.WriteLine(u.Count);

            Console.WriteLine("Accessimg all the elements of the User list using foreach loop :- ");
            foreach (user item in u)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Location = {2}", item.ID, item.Name, item.Location);
            }

            Console.WriteLine("Accessing the elements of lst :- ");
            Console.WriteLine(lst[0]);
            Console.WriteLine(lst[5]);

            Console.WriteLine("Accessing elements of user list using for loop :- ");
            for (int i = 0; i < u.Count; i++)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Location = {2}", u[i].ID, u[i].Name, u[i].Location);
            }

            // Inserting elements into list lst
            lst.Insert(0, 45);
            lst.Insert(2, 95);
            lst.InsertRange(4, lst2);

            Console.WriteLine("\nCheck for an element exists or not in the list lst :- ");
            Console.WriteLine(lst.Contains(95));   // True
            Console.WriteLine(lst.Contains(85));   // False

            // Removing an element from list lst
            lst.Remove(95);
            lst.Remove(55);
            lst.RemoveAt(2);
            lst.RemoveRange(4, 3);

            Console.ReadLine();
        }
    }
}
