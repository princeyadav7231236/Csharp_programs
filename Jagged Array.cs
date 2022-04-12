using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of creating Jagged arrays

            // Single Dimensional array
            int[][] arr1 = new int[2][];
            // 2D array
            int[][,] arr2 = new int[3][,];

            // Different ways of Initializing and declaring Jagged arrays

            // single Dimensional array
            int[][] arr3 = new int[3][];
            arr3[0] = new int[5] { 1, 2, 3, 4, 5 };
            arr3[1] = new int[2] { 1, 2};
            arr3[2] = new int[3]{ 1, 2, 3};
            // 2D array
            int[][,] arr4 = new int[3][,];
            arr4[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            arr4[1] = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            arr4[2] = new int[2, 1] { { 1 }, { 3 } };

            // Initializing an array on decleration
            int[][] arr5 = new int[][]
            {
                new int[] {1, 2, 3},
                new int[]{4, 5,6},
                new int[]{7, 8, 9}
            };

            // Access Jagged array Elements
            int i = arr5[1][1];
            int j = arr5[2][0];
            int k = arr4[1][1, 1];
            int l = arr4[0][0, 1];
            /*Console.WriteLine(i); // 5
            Console.WriteLine(j); // 7
            Console.WriteLine(k); // 4
            Console.WriteLine(l); // 2*/

            for (int x = 0; x < arr5.Length; x++)
            {
                Console.Write("Element [{0}]  ", x);
                for (int y = 0; y < arr5[x].Length; y++)
                {
                    Console.Write("  {0}{1}", arr5[x][y], y == (arr5[x].Length - 1) ?
                        "  " : " ");
                }
                Console.WriteLine();
            }


            // Jagged array for two dimensional array

            /*// 2D array
            int[][,] arr4 = new int[3][,];
            arr4[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            arr4[1] = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            arr4[2] = new int[2, 1] { { 1 }, { 3 } };*/
 
            for (int x = 0; x < arr4.Length; x++)
            {
                Console.Write("Element [{0}]  ", x);
                for (int y = 0; y < arr4[x].GetLength(0); y++)
                {
                    Console.Write("{");
                    for (int z = 0; z < arr4[x].GetLength(1); z++)
                    {
                        Console.Write(" {0}{1}", arr4[x][y, z], z == (arr4[x].GetLength(1) - 1) ?
                            " " : " , ");
                    }
                    Console.Write("{0}{1} ", "}", y < arr4[x].GetLength(0) - 1 ? " , " : " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
