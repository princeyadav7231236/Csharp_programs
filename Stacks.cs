using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            // Adding elements to the Stack.
            stk.Push("Doremon and Pyari Doctor");
            stk.Push("Doctor");
            stk.Push("Doremon");
            stk.Push(1);
            stk.Push(null);
            stk.Push(null);

            // Count the total number of elements in the Stack.
            Console.WriteLine(stk.Count);   // 6

            // Romove the top element of the Stack.
            Console.WriteLine("Result :--> {0}", stk.Pop());   // null

            // Get the top value of the Stack.
            Console.WriteLine("Result :--> {0}", stk.Peek());   // null
            Console.WriteLine("Result :--> {0}", stk.Peek());   // null

            // Check if the given Stack stk is Syncronised or not.
            Console.WriteLine("Syncronised :--> {0}", stk.IsSynchronized);   // False

            // Check if the given element is in the Stack or not.
            Console.WriteLine(stk.Contains("Doctor"));                     // True       
            Console.WriteLine(stk.Contains("Doremon"));                    // True     
            Console.WriteLine(stk.Contains("Doremon and Pyari Doctor"));   // True
            Console.WriteLine(stk.Contains(100));                          // False

            // Accessing all the elements of the Stack using foreach loop.
            Console.WriteLine("Accessing all the elements of the Stack using foreach loop.");
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
