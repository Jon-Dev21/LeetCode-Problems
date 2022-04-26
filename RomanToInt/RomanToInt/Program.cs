using System;
using System.Threading;

namespace Roman_To_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a roman numeral.");
                string romanNumber = Console.ReadLine();
                Console.WriteLine("Numeral value for {0} is {1}", romanNumber, RomanToInt(romanNumber));
                Thread.Sleep(5000);
                Console.Clear();
            }

        }

        public static int RomanToInt(string s)
        {
            int numberValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        // Add 1 to the number value.
                        numberValue += 1;
                        break;
                    case 'V':
                        // Add 5 to the number value.
                        numberValue += 5;
                        // Validate that the next index is valid.
                        if (i - 1 >= 0)
                        {
                            // Check if there was a 'I' to see if it's a 4.
                            if (s[i - 1] == 'I')
                            {
                                // Subtract 1 since the roman numeral is 4.
                                numberValue -= 1;
                                i = i - 1;
                            }
                        }
                        break;
                    case 'X':
                        // Add 10 to the number value.
                        numberValue += 10;
                        // Validate that the next index is valid.
                        if (i - 1 >= 0)
                        {
                            // Check if there was a 'I' to see if it's a 9.
                            if (s[i - 1] == 'I')
                            {
                                // Subtract 1 since the roman numeral is 9.
                                numberValue -= 1;
                                i = i - 1;
                            }
                        }
                        break;
                    case 'L':
                        // Add 50 to the number value.
                        numberValue += 50;
                        // Validate that the next index is valid.
                        if (i - 1 >= 0)
                        {
                            // Check if there was a 'X' to see if it's a 40 (XL).
                            if (s[i - 1] == 'X')
                            {
                                // Subtract 10 since the roman numeral is 40.
                                numberValue -= 10;
                                i = i - 1;
                            }
                        }
                        break;
                    case 'C':
                        // Add 100 to the number value.
                        numberValue += 100;
                        // Validate that the next index is valid.
                        if (i - 1 >= 0)
                        {
                            // Check if there was a 'X' to see if it's a 90 (XC).
                            if (s[i - 1] == 'X')
                            {
                                // Subtract 10 since the roman numeral is 90.
                                numberValue -= 10;
                                i = i - 1;
                            }
                        }
                        break;
                    case 'D':
                        // Add 500 to the number value.
                        numberValue += 500;
                        // Validate that the next index is valid.
                        if (i - 1 >= 0)
                        {
                            // Check if there was a 'C' to see if it's a 400 (CD).
                            if (s[i - 1] == 'C')
                            {
                                // Subtract 100 since the roman numeral is 400.
                                numberValue -= 100;
                                i = i - 1;
                            }
                        }
                        break;
                    case 'M':
                        // Add 1000 to the number value.
                        numberValue += 1000;
                        // Validate that the next index is valid.
                        if (i - 1 >= 0)
                        {
                            // Check if there was a 'C' to see if it's a 900 (CM).
                            if (s[i - 1] == 'C')
                            {
                                // Subtract 100 since the roman numeral is 900.
                                numberValue -= 100;
                                // Continue to the next index
                                i = i - 1;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            return numberValue;
        }
    }
}
