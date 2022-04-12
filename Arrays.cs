using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Different ways of initializing and declaring an array in csharp
            int[] array1 = new int[5];
            int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] array3 = new int[] { 1, 2, 3 };
            int[] array4 = { 1, 2, 3, 4, 5 };
            int[] array5;
            array5 = new int[] { 1, 2, 3, 4 };
            int[] array6 = new int[2];
            array6[0] = 1;
            array6[1] = 2;

            // Error initialize an array without size 
            //int[] array7 = new int[];

            // Error initialize an array without new keyword
            /*int[] array8;
            array8 = {1, 2, 3, 4};*/

            // Access an array element with for loop
            /*int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/

            // Access an array element with foreach type
            /*foreach (int elements in arr)
            {
                Console.WriteLine(elements);
            }*/

            int[] arr = new int[] { 7, 2, 3, 9, 8, 6, 1, 5, 4 };
            Array.Sort(arr);
            foreach (int elements in arr)
            {
                Console.WriteLine(elements);
            }
            Array.Reverse(arr);
            foreach (int elements in arr)
            {
                Console.WriteLine(elements);
            }
            Console.ReadLine();
        }
    }
}
