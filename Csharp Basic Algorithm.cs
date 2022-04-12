using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basic_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // 1.) Write a C# Sharp program to compute the sum of the two given integer values.
                // If the two values are the same, then return triple their sum.
                // User input : 1, 2  ; 3, 2  ; 2, 2   :--> Output => 3, 5, 12

                /*Console.WriteLine("Enter First Number : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number : ");
                int num2 = int.Parse(Console.ReadLine());
                int result;
            
                if(num1 == num2)
                {
                    result = (num1 + num2) * 3;
                    Console.WriteLine("The result is :-- {0} ", result);
                }
                else
                {
                    result = num1 + num2;
                    Console.WriteLine("The result is :-- {0} ", result);
                }*/

                // 2.) Write a C# program to get the absolute difference between n and 51. If n is greater than 51 
                // return triple the absolute difference.
                // User Input : 53 ; 30; 51     :--> Output => 6; 12; 0

                /*Console.Write("Enter the number : ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                int result2;
                if(num3 > 51)
                {
                    result2 = (num3 - 51) * 3;
                    Console.WriteLine("The result is : {0}", result2);
                }
                else
                {
                    result2 = 51 - num3;
                    Console.WriteLine("The result is : {0}", result2);
                }*/

                // 3.) Write a C# program to check two given integers, and return true if one of them is 30 or
                // if their sum is 30.
                // Sample input : 30, 0 ; 25, 5 ; 20, 30 ; 20, 25    :--> Output => True, True, True, False

                /*Console.WriteLine("Enter First number : ");
                int num4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second number : ");
                int num5 = int.Parse(Console.ReadLine());
                if (num4 == 30 || num5== 30)
                {
                    Console.WriteLine(true);
                }
                else if ((num4 + num5) == 30)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }*/

                // 4.) Write a C# program to check a given integer and return true if it is within 10 of 100 or 200.
                // Sample Input : 103; 90; 89; 190; 189; 205; 211   :--> Output => true; true; false; true; false; true; false.

                /*Console.Write("Enter your number : ");
                int num6 = Convert.ToInt32(Console.ReadLine());
                if (num6 >= 90 && num6 <= 110)
                    Console.WriteLine(true);
                else if (num6 >= 190 && num6 <= 210)
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);*/

                // 5.) Write a C# program to create a new string where "if" is added to the front of a given string 
                // already begins with "if", return the string unchanged.
                // Sample input : if else; else   :-->  Output => if else; if else.

                /*Console.Write("Enter your String :-- ");
                string str1 = Console.ReadLine();
                if (str1.StartsWith("if"))
                {
                    Console.WriteLine(str1);
                }
                else
                {
                    str1 = "if " + str1;
                    Console.WriteLine(str1);
                }*/

                // 6.) Write a C# porgram to remove the character in a given position of a given string. The given
                // position will be in the range 0 .. string length -1 inclusive.
                // Sample input : Python, 1 ;Python, 0 ;Python, 4   :--> Output => Pthon, ython, Pythn.

                /*Console.WriteLine("Enter your String : ");
                string str2 = Console.ReadLine();
                Console.WriteLine("Index of the character which you want to remove the given string -- {0}", str2);
                int num7 = int.Parse(Console.ReadLine());
                string result;
                if(num7 >= 0 && num7 <= str2.Length - 1)
                {
                    result = str2.Remove(num7, 1);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("index out of range");
                }*/

                // 7.) Write a C# program to exchange the first and last character in a given string and return the 
                // new string.
                // Sample input : abcd; a; xy   :--> Output => dbca; a; yx

                /*Console.WriteLine("Enter your String : ");
                string str3 = Convert.ToString(Console.ReadLine());
                string result;
            
                if(str3.Length < 2)
                {
                    Console.WriteLine("The given string cannot be reversed , therefore the result is :- {0}", str3);
                }
                else
                {
                    char firstChar = str3[0];
                    char lastChar = str3[str3.Length - 1];
                    str3 = str3.Replace(firstChar, lastChar); 
                    str3 = str3.Remove(str3.Length - 1);  
                    result = str3 + firstChar;
                    Console.WriteLine("After reversing the first and the last character the new string we get is :- {0}", result);                
                }*/

                // 8.) Write a C# Program to create a new string which is 4 copies of the 2 front characters of a given string.
                // If the given string length is less than 2 return the original string.
                // Sample Input : C Sharp; JS; a   :--> Output => C C C C; JSJSJSJS; a.

                /*Console.WriteLine("Enter your string : ");
                string str4 = Console.ReadLine();            
                if(str4.Length < 2)
                {
                    Console.WriteLine("Result :-- {0}", str4);
                }
                else
                {
                    if (str4.Length > 2)
                    {
                        str4 = str4.Remove(2);
                    }
                    str4 = str4 + str4 + str4 + str4;
                    Console.WriteLine("Result :-- {0}", str4);
                }*/

                // 9.)  Write a C# Sharp program to create a new string with the last char added at the front
                // and back of a given string of length 1 or more. 
                //Sample Input:  "Red"; "Green"; "1"   :--> Expected Output => dRedd; nGreenn; 111.

                /*Console.WriteLine("Enter your string : ");
                string str5 = Console.ReadLine();
                string str6 = str5.Substring(str5.Length-1);
                string result;            
                if(str5.Length > 0)
                {
                    result = str6 + str5 + str6;
                    Console.WriteLine("The result is : {0}", result);
                }
                else
                {
                    Console.WriteLine("The string is empty");
                }*/

                // 10.) Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
                // Sample Input: 3; 14; 12; 37   :--> Expected Output  => True; True; True; False.

                /*Console.WriteLine("To check the numbers divisibility by 3 and 7");
                Console.WriteLine("Enter your number : ");
                int num8 = Convert.ToInt32(Console.ReadLine());
                if (num8 % 3 == 0) 
                {
                    Console.WriteLine(true);
                }
                else if(num8 % 7 == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }*/

                // 11.) Write a C# program to check whether a given string starts with "C#" or not.

                /*Console.WriteLine("Enter your string : ");
                string str9 = Console.ReadLine();
                if (str9.StartsWith("C#"))
                {
                    Console.WriteLine("Result : {0}", true);
                }
                else
                {
                    Console.WriteLine("Result : {0}", false);
                }*/

                // 12.) Write a C# program to check if one given temperature is less than 0 and the other is 
                // greater than 100

                /*Console.WriteLine("Enter first temperature : ");
                int num10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second temperature : ");
                int num11 = Convert.ToInt32(Console.ReadLine());

                if((num10 < 0 || num10 > 100 )&& (num11 < 0 || num11 > 100))
                {
                    Console.WriteLine("Result : {0}", true);
                }
                else
                {
                    Console.WriteLine("Result : {0}", false);
                }*/

                // 13.) Write a C# program to check whether three given integer values are in the range 20 .... 50 inclusive. 
                // Return true if 1 or more of them are in the said range otherwise false.

                /*Console.WriteLine("Enter first number : ");
                int num12 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int num13 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third number : ");
                int num14 = int.Parse(Console.ReadLine());

                if ((num12 >= 20 && num12 <= 50) || (num13 >= 20 && num13 <= 50) || (num14 >= 20 && num14 <= 50)) 
                {
                    Console.WriteLine("Result : {0}", true);
                }
                else
                {
                    Console.WriteLine("Result : {0}", false);
                }*/

                // 14.) Write a C# program to check if a string 'yt' appears at index 1 in a given string.
                // If it appears return a string without 'yt' otherwise return the original string.

                /*Console.WriteLine("Enetr your string : ");
                string str20 = Console.ReadLine();

                if (str20.Substring(1, 2) == "yt")
                {
                    str20 = str20.Remove(1, 2);
                    Console.WriteLine("Result : {0}", str20);
                }
                else
                {
                    Console.WriteLine("Result : {0}", str20);
                }*/

                // 15.) Write a C# program to check the largest number among the three given integers.

                /*Console.WriteLine("Enter first number : ");
                int num15 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int num16 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third number : ");
                int num17 = int.Parse(Console.ReadLine());
                if(num15 > num16)
                {
                    if(num15 > num17)
                    {
                        Console.WriteLine("Result : {0}", num15);
                    }
                    else
                    {
                        Console.WriteLine("Result : {0}", num17);
                    }
                }
                else
                {
                    if(num16 > num17)
                    {
                        Console.WriteLine("Result : {0}", num16);
                    }
                    else
                    {
                        Console.WriteLine("Result : {0}", num17);
                    }
                }*/

                // 16.) Write a C# program to check which number nearest to the value 100 among two given integers.
                // Return 0 if the two numbers are equal.

                /*try
                {
                    Console.WriteLine("Enter first number : ");
                    uint num18 = uint.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number : ");
                    uint num19 = uint.Parse(Console.ReadLine());
                    uint num20 = num18;
                    uint num21 = num19;
                    if(100 > num18 && 100 > num21)
                    {
                        num20 = 100 - num20;
                        num21 = 100 - num21;
                        if (num20 < num21)
                        {
                            Console.WriteLine("Result : {0}", num18);
                        }
                        else if (num20 == num21)
                        {
                            Console.WriteLine("Result : 0");
                        }
                        else
                        {
                            Console.WriteLine("Result : {0}", num19);
                        }

                    }
                    else
                    {
                        num20 = num20 - 100;
                        num21 = num21 - 100;
                        if (num20 < num21)
                        {
                            Console.WriteLine("Result : {0}", num18);
                        }
                        else if (num20 == num21)
                        {
                            Console.WriteLine("Result : 0");
                        }
                        else
                        {
                            Console.WriteLine("Result : {0}", num19);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You entered a negative integer");
                } */

                // 17.) Write a C# program to check whether two given integers are in the range 40....50 inclusive,
                // or they are both in the range 50...60 inclusive.

                /*Console.WriteLine("Enter first number : ");
                int num20 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int num21 = int.Parse(Console.ReadLine());
                if(((num20 >= 40 && num20 <= 50) || (num20 >= 50 && num20 <= 60)) && ((num21 >= 40 && num21 <= 50) || (num21 >= 50 && num21 <= 60)))
                {
                    Console.WriteLine("Result : {0}", true);
                }
                else
                {
                    Console.WriteLine("Result : {0}", false);
                }*/

                // 18.) Write a C# program two find a larger value from two positive integer values that is in the range 
                // 20....30 inclusive, or return 0 if neither is in that range

                /*Console.WriteLine("Enter first number : ");
                int num22 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int num23 = int.Parse(Console.ReadLine());
                if ((num22 >= 20 && num22 <= 30) && (num23 >= 20 && num23 <= 30)) 
                {
                    if(num22 > num23)
                    {
                        Console.WriteLine("Result : {0}", num22);
                    }
                    else if(num22 == num23)
                    {
                        Console.WriteLine("Result : {0}", num22);
                    }
                    else
                    {
                        Console.WriteLine("Result : {0}", num23);
                    }
                }
                else
                {
                    Console.WriteLine("Result : 0");
                }*/

                // 19.) Write a C# program to check if a given string contains between 2 and 4 'z' character

                /*Console.WriteLine("Enter your string : ");
                string str21 = Console.ReadLine();
                string str22;
                if(str21.Length < 5)
                {
                    try
                    {
                        str22 = str21.Substring(2);
                        if (str22.Contains("z"))
                        {
                            Console.WriteLine("Result : {0}", true);
                        }
                        else
                        {
                            Console.WriteLine("Result : {0}", false);
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Result : {0}", false);
                    }
                }
                else
                {
                    str22 = str21.Substring(2, 3);
                    if (str22.Contains("z"))
                    {
                        Console.WriteLine("Result : {0}", true);
                    }
                    else
                    {
                        Console.WriteLine("Result : {0}", false);
                    }
                }*/

                // 20.) Write a C# program to check if two given non-negative integers have the same last digit.

                /*Console.WriteLine("Enter first number : ");
                int num24 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int num25 = int.Parse(Console.ReadLine());
                if (num24 > -1 && num25 > -1)
                {
                    string str21 = num24.ToString();
                    string str22 = num25.ToString();
                    Char ch1 = str21[str21.Length - 1];
                    Char ch2 = str22[str22.Length - 1];
                    if(ch1 == ch2)
                    {
                        Console.WriteLine("Result : {0}", true);
                    }
                    else
                    {
                        Console.WriteLine("Result : {0}", false);
                    }
                }
                else
                {
                    Console.WriteLine("You entered a negative integer");
                }*/

                // 21.) Write a C# program to convert the last three characters of a given string in upper case.
                // If the length of the string has less than 3  then uppercase all the characters.

                /*Console.WriteLine("Enter the String : ");
                string str23 = Console.ReadLine();
                if(str23.Length < 3)
                {
                    Console.WriteLine("Result : {0}", str23.ToUpper());
                }
                else
                {
                    str23 = str23.Remove(str23.Length - 3) + str23.Substring(str23.Length - 3).ToUpper();
                    Console.WriteLine("Result : {0}", str23);
                }*/

                // 22.) Write a C# program to create a new string which is n(non-negative integer) copies of a given string.

                /*Console.WriteLine("Enter your string : ");
                string str24 = Console.ReadLine();
                Console.WriteLine("Enter the number : ");
                string str25 = str24;
                int num22 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < num22; i++)
                {                    
                    str24 += str25;
                }
                Console.WriteLine("Result : {0}", str24);*/

                // 23.) Write a C# program to create a new string which is n(non-negative integer) copies of the 
                // first 3 characters of a given string. If the length of the given string is less than 3 then return n copies of the string.

                /*Console.WriteLine("Enter the string : ");
                string str26 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the number : ");
                int num23 = Convert.ToInt32(Console.ReadLine());
                string str27;
                if(str26.Length < 3)
                {
                    str27 = str26;
                    for (int i = 1; i < num23; i++)
                    {
                        str26 += str27;
                    }
                    Console.WriteLine("Result : {0}", str26);
                }
                else
                {
                    str26 = str26.Remove(3);
                    str27 = str26;
                    for (int i = 1; i < num23; i++)
                    {
                        str26 += str27;
                    }
                    Console.WriteLine("Result : {0}", str26);
                }*/

                // 24.) Write a C# program to count the string "aa" in a given string and assume "aaa" contains two "aa".

                Console.WriteLine("Enter the String : ");
                string str28 = Console.ReadLine();
                int count = 0;
                
                if (str28.Contains("aaa"))
                {
                    for (int i = 0; i < str28.Length - 2; i++)
                    {
                        string str29 = str28[i].ToString() + str28[i + 1].ToString() + str28[i + 2].ToString();                        
                        if (str29 == "aaa")
                        {
                            count += 2;
                            str28 = str28.Remove(i, i + 2);
                        }            
                    }
                }  
                else if (str28.Contains("aa"))
                {
                    for (int i = 0; i < str28.Length - 2; i++)
                    {
                        string str30 = str28[i].ToString() + str28[i + 1].ToString();
                        if (str30 == "aa")
                        {
                            count += 1;
                            try
                            {
                                str28 = str28.Remove(i, i + 1);
                            }
                            catch (Exception e)
                            {

                            }
                        }
                    }
                }
                else
                {                    
                    Console.WriteLine("Result : 0");
                }
                Console.WriteLine("Result : {0}", count);

                Console.ReadLine();
            }

        }
    }
}
  