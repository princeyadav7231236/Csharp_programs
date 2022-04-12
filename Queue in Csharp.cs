using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue("Doremon and Pyari Doctor");
            que.Enqueue("Doctor");
            que.Enqueue("Shinchan");
            que.Enqueue("Doremon");
            que.Enqueue(20.48454);
            que.Enqueue(null);

            // Total number of elements present in the Queue.
            Console.WriteLine(que.Count);   // 7

            // Set the Capacity of the Queue to the actual number of elements in the Queue.
            que.TrimToSize();            
            
            // Removes first element from the Queue.
            que.Dequeue();

            // Returns the first element of the Queue.
            Console.WriteLine(que.Peek());  // Doremon and Pyari Doctor
            Console.WriteLine(que.Peek());  // Doremon and Pyari Doctor

            // Checks if the given element is in the Queue or not.
            Console.WriteLine(que.Contains("Doremon and Pyari Doctor"));    // True
            Console.WriteLine(que.Contains("Doctor"));     // True
            Console.WriteLine(que.Contains("Doremon"));    // True
            Console.WriteLine(que.Contains(100));    // False

            // Accessing all the elements of the Queue using foreach loop.
            Console.WriteLine("Accessing all the elements of the Queue using foreach loop.");
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
