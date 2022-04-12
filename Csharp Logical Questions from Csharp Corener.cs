using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Logical_Questions_from_Csharp_Corner
{
    class clsSwapNeighbour
    {
        public static string SwapNeighbour(string strToSwap)
        {
            Char[] arrStr = strToSwap.ToCharArray();
            StringBuilder strBuild = new StringBuilder();
            for (int i = 0; i < arrStr.Length ; i++)
            {
                if (i != arrStr.Length - 1)
                    strBuild.Append(arrStr[i + 1]);
                strBuild.Append(arrStr[i]);
                i += 1;
            }
            return strBuild.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1.) Exchange two integer variable without using the third Variable

            /*int a = 10;
            int b = 5;
            Console.WriteLine("Before a : {0}",a);
            Console.WriteLine("Before b : {0}",b);
            a = a + b;   // 5 + 10 = 15
            b = a - b;   // 15 - 5 = 10
            a = a - b;   // 15 - 10 = 5
            Console.WriteLine("After a : {0}",a);
            Console.WriteLine("After b : {0}",b);*/

            // 2.) Swap neighbour char in string, for example string "TAPAN" would be "ATAPN".
            /*string text = "TAPAN";
            Console.WriteLine(clsSwapNeighbour.SwapNeighbour(text));*/

            // 3.) Is Prime Number?
            /*while (true)
            {
                Console.WriteLine("Enter the number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i < number; i++)
                {
                    if ((number % i) == 0)
                    {
                        Console.WriteLine("The Given number {0} is not a prime number", number);
                        break;
                    }
                    else
                    {
                        if (i < number - 1)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("The Given number {0} is a prime number", number);
                        }
                    }
                }
            }*/

            // 4.) Fibonacci Series.  example:-  0 1 1 2 3 5 8 13 21 34 ........
            /*List<int> lst = new List<int>();
            int digit1 = 0, digit2 = 1, digit3 = digit1 + digit2;            
            lst.Add(digit3);
            for (int i = 0; ; i++)
            {
                digit1 = digit2;
                digit2 = digit3;
                digit3 = digit1 + digit2;
                if (digit3 > 4000000)
                    break;
                else
                    lst.Add(digit3);
            }*/
            /*foreach (int item in lst)
            {
                Console.WriteLine(item);
            }*/
            /*long sumOfEvenNumber = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                if ((lst[i] % 2) == 0)
                    sumOfEvenNumber += lst[i];
                
            }
            Console.WriteLine("The sum of all Even Fibonacci series number is : {0}", sumOfEvenNumber);*/

            // 5.) Factorial.   for example :-  5! = 5*4*3*2*1 = 120
            /*Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(number));  */

            //  6.) Largest Prime Factor :- The prime factor of 13195 are 5, 7, 13 and 29.
            // What is the largest prime factor of the number 600851475143.
            /*long number = 600851475143L;
            List<long> lst2 = new List<long>();
            for (long i = 1; i < number; i++)
            {
                if(number % i == 0)
                    lst2.Add(i);
            }
            Console.WriteLine("The largest prime factor of the number 600851475143 is {0}", lst2.Max());*/

            // 7.) A palindromic number reads the same both ways. The largest palindrome made from the product of 
            // two 2- digit number is 9009 = 91 * 99.
            // Find the largest palindrome made from the product of two 3 - digit number.

            List<string> lst3 = new List<string>();
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    string num = "" + (i * j);
                    char[] arr = num.ToCharArray();
                    char[] result = new char[arr.Length];
                    for(int a = 0, b = arr.Length-1; a < arr.Length; a++, b--)
                    {
                        result[a] = arr[b];
                    }
                    if (Array.Equals(arr, result))
                    {
                        lst3.Append(num);
                    }
                }
            }
            Console.WriteLine("The largest palindrome of 3 digit number is : {0}", lst3.Max());



            Console.ReadLine();
        }
        /*static int Fibonacci(int number)
        {            
            if(number < 2)
            {
                return 1;
            }
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }   */

        /*static int factorial(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            return number * factorial(number - 1);
        }*/
    }
}
