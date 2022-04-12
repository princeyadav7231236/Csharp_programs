using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multi Dimensional arrays decleration

            // 2D arrays
            int[,] arr1 = new int[4, 2];
            // 3D arrays
            int[,,] arr2 = new int[4, 2, 3];

            // Multi Dimensional arrays decleration

            // 2D integer arrays
            int[,] arr3 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] arr4 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            // Access 2D array elements
            Console.WriteLine(arr4[1, 0]);

            // 3D integer arrays
            int[,,] arr5 = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                { { 7, 8, 9 }, { 10, 11, 12 } } };
            int[,,] arr6 = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                { { 7, 8, 9 }, { 10, 11, 12 } } };
            // Access 3D array elements
            Console.WriteLine(arr5[0, 1, 2]);

            // Accessing all the elements of 2D arrays using for loop
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", i, j, arr3[i, j]);
                }
            }

            // Accessing all the elements of 3D arrays using for loop
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("a[{0}, {1}, {2}] = {3}", i, j, k,arr6[i, j, k]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
