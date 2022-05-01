using System;
using System.Threading;

namespace IntToRoman
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Please enter a number from 1 to 20000:");
                string number = Console.ReadLine();
                int num = Int32.Parse(number);
                if (num >= 1 && num <= 20000)
                {
                    Console.WriteLine("Roman value for {0} is {1}", number, IntToRoman(num));
                    Thread.Sleep(5000);
                }
                else
                {
                    Console.WriteLine("Please write a number between 1 and 20000: ");
                    Thread.Sleep(2000);
                }
                    
                Console.Clear();
            }
        }

        public static string IntToRoman(int num)
        {
            string romanNumeral = "";

            int M = 1000;
            int D = 500;
            int C = 100;
            int L = 50;
            int X = 10;
            int V = 5;
            int I = 1;


            while(num!=0)
            {
                // If I can subtract 1000 and the result is greater than or equal to 0
                if(num-M >= 0 || num - M >= -100 && num - M <= -1)
                {
                    if (num - M >= -100 && num - M <= -1)
                    {
                        // Subtract 900.
                        num -= 900;
                        romanNumeral += "CM";
                    }
                    else
                    {
                        // Subtract 1000.
                        num -= M;
                        romanNumeral += "M";
                    }
                }
                else if (num - D >= 0 || num - D >= -100 && num - D <= -1)
                {
                    if (num - D >= -100 && num - D <= -1)
                    {
                        // Subtract 400.
                        num -= 400;
                        romanNumeral += "CD";
                    } 
                    else
                    {
                        // Subtract 500.
                        num -= D;
                        romanNumeral += "D";
                    }
                }
                else if (num - C >= 0 || num - C == -100 || num - C >= -10 && num - C <= -1)
                {
                    if (num - C == -100 || num - C >= -10 && num - C <= -1)
                    {
                        // Subtract 90.
                        num -= 90;
                        romanNumeral += "XC";
                    }
                    else
                    {
                        // Subtract 100.
                        num -= C;
                        romanNumeral += "C";
                    }
                }
                else if (num - L >= 0 || num - L >= -10 && num - L <= -1)
                {
                    if (num - L >= -10 && num - L <= -1)
                    {
                        // Subtract 40.
                        num -= 40;
                        romanNumeral += "XL";
                    }
                    else
                    {
                        // Subtract 50.
                        num -= L;
                        romanNumeral += "L";
                    }
                }
                else if (num - X >= 0 || num - X == -1)
                {
                    if(num - X == -1)
                    {
                        // Subtract 9.
                        num -= 9;
                        romanNumeral += "IX";
                    }
                    else
                    {
                        // Subtract 10.
                        num -= X;
                        romanNumeral += "X";
                    }
                    
                }
                else if (num - V >= 0 || num - V == -1)
                {
                    if (num - V == -1)
                    {
                        // Subtract 4.
                        num -= 4;
                        romanNumeral += "IV";
                    }
                    else
                    {
                        // Subtract 5.
                        num -= V;
                        romanNumeral += "V";
                    }
                    
                }
                else if (num - I >= 0)
                {
                    // Subtract.
                    num -= I;
                    romanNumeral += "I";
                }
            }
            return romanNumeral;
        }
    }
}
