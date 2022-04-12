using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Params Keyword for specified int type
            ParamMethod(1, 2, 3, 4, 5, 5, 6, 8, 7);

            // Using Params Keyword for Object type 
            ParamMethodForObjectType(1, "Pyari Doctor", "Shinchan", 45.45f, true);

            Console.ReadLine();
        }
        static void ParamMethod(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? " , " : " "));
            }
            Console.WriteLine();
        }
        static void ParamMethodForObjectType(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? " , " : " "));
            }
            Console.WriteLine();
        }

    }
}
