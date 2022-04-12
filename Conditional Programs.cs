using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.) C# Program to check whether an integer entered by an user is odd or even
            /*int number;
            Console.Write("Enter the Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("{0} is even.", number);
            else
                Console.WriteLine("{0} is Odd", number);*/

            // 2.) C# Program to find the Largest number among three
            /*int num1, num2, num3;
            Console.Write("Enter the First Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Third Number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("Num1 is the largest number with value = {0}", num1);
                }
                else
                {
                    Console.WriteLine("Num3 is the largest number with value = {0}", num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Num2 is the largest number with value = {0}", num2);
                }
                else
                {
                    Console.WriteLine("Num3 is the largest number with value = {0}", num3);
                }
            }*/

            // 3.) C# program to find the largest number using Conditional Operator
            /*int num1, num2, num3, largest;
            Console.Write("Enter the First Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Third Number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            largest = num1 > num2 ?( num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3) ;
            Console.WriteLine("The largest number is {0}", largest);*/

            // 4.) Program to find the largest among three variables using nested if.
            // its solution is same as program 2

            // 5.) C# Program to check leap year using Conditional Operator
            /*int year;
            string check;
            Console.Write("Enter the Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            check = year % 4 == 0 ? "a Leap Year" : "Not a Leap Year";
            Console.WriteLine("{0} is {1}", year, check);*/

            // 6.) C# Program to check whether an alphabet is a vovel or not
            /*char[] vovel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char alphabet;            
            while (true)
            {
            Console.Write("Enter your Alphabet : ");
            alphabet = Convert.ToChar(Console.ReadLine());

                switch (alphabet)
                {
                    case 'a':
                        Console.WriteLine("{0} is a Vovel", alphabet);
                        break;
                    case 'e':
                        Console.WriteLine("{0} is a Vovel", alphabet);
                        break;
                    case 'i':
                        Console.WriteLine("{0} is a Vovel", alphabet);
                        break;
                    case 'o':
                        Console.WriteLine("{0} is a Vovel", alphabet);
                        break;
                    case 'u':
                        Console.WriteLine("{0} is a Vovel", alphabet);
                        break;
                    default:
                        Console.WriteLine("{0} is not a Vovel", alphabet);
                        break;
                }
            }
                */
            //                              OR

            /*for (int i = 0; i < vovel.Length; i++)
            {
                if (alphabet == vovel[i])
                {
                    Console.WriteLine("The Given Alphabet \"{0}\" is a Vovel ", alphabet);
                    break;
                }
                else
                {
                    Console.WriteLine("The Given alphabet \"{0}\" is not a Vovel ", alphabet);
                }
            }*/

            // 7.) C# Program to check number is Positive, Negative or Zero
            /*int number;
            Console.Write("Enter your Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("The given number {0} is Positive", number);
            else if (number < 0)
                Console.WriteLine("The given number {0} is Negative", number);
            else
                Console.WriteLine("The given number {0} is Zero", number);*/

            // 8.) C# Program to check UpperCase or LowerCase alphabets
            /*char alphabet;
            Console.Write("Enter your Alphabet : ");
            alphabet = Convert.ToChar(Console.ReadLine());

            if ((int)alphabet >= 65 && (int)alphabet <= 90)
                Console.WriteLine("The given Alphabet {0} is in UpeerCase ", alphabet);
            else if ((int)alphabet >= 97 && (int)alphabet <= 122)
                Console.WriteLine("The given Alphabet {0} is in LowerCase ", alphabet);
            else
                Console.WriteLine("The Entered value is not an Alphabet");*/

            // 9.) C# Program to check entered character Vovel or Consonent
            /*char alphabet;
            string result;
            Console.Write("Enter your Alphabet : ");
            alphabet = Convert.ToChar(Console.ReadLine());

            result = alphabet == 'a' || alphabet == 'e' || alphabet == 'i' ||
                alphabet == 'o' || alphabet == 'u' || alphabet == 'A' ||
                alphabet == 'E' || alphabet == 'I' || alphabet == 'O' ||
                alphabet == 'U' ? "The given alphabet {0} is an Vovel" :
                ((alphabet >= 'a' && alphabet <= 'z') || (alphabet >= 'A' && alphabet <= 'Z')) ?
                "The Given alphabet {0} is an Consonent" : "The Given alphabet {0} is not an Alphabet";
            Console.WriteLine(result, alphabet);
*/






            Console.ReadLine();
        }
    }
}
