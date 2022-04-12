using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_keyword_with_object_type
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod(1, "Shinchan and Pyari Doctor", "Rani Sahiba", "XR Developer", 45.8724);
            Console.ReadLine();            
        }
        public static void ParamsMethod(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? " , " : " "));
            }
        }
    }
}
