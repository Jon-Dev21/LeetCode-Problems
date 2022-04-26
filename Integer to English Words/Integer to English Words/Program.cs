using System;
using System.Collections.Generic;
using System.Threading;

namespace Integer_to_English_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Console.Write("Please enter a number: ");
                //string number = Console.ReadLine();
                //Console.WriteLine("Numeric value in words for {0} is {1}", number, NumberToWords(Int32.Parse(number)));
                //Thread.Sleep(300);
                //Console.WriteLine("\n");
                //Console.Clear();

                for (int i = 0; i <= int.MaxValue; i++)
                {
                    Console.WriteLine("Numeric value in words for {0} is {1}", i, NumberToWords(i));

                    //Thread.Sleep(200);
                }
                Console.ReadKey();
            }
        }

        public static string NumberToWords(int num)
        {
           var numberNames = new Dictionary<int, string>();
            numberNames.Add(0, "Zero");
            numberNames.Add(1, "One"); 
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            numberNames.Add(4, "Four");
            numberNames.Add(5, "Five");
            numberNames.Add(6, "Six");
            numberNames.Add(7, "Seven");
            numberNames.Add(8, "Eight");
            numberNames.Add(9, "Nine");
            numberNames.Add(10, "Ten");
            numberNames.Add(11, "Eleven");
            numberNames.Add(12, "Twelve");
            numberNames.Add(13, "Thirteen");
            numberNames.Add(14, "Fourteen");
            numberNames.Add(15, "Fifteen");
            numberNames.Add(16, "Sixteen");
            numberNames.Add(17, "Seventeen");
            numberNames.Add(18, "Eighteen");
            numberNames.Add(19, "Nineteen");
            numberNames.Add(20, "Twenty");
            numberNames.Add(30, "Thirty");
            numberNames.Add(40, "Forty");
            numberNames.Add(50, "Fifty");
            numberNames.Add(60, "Sixty");
            numberNames.Add(70, "Seventy");
            numberNames.Add(80, "Eighty");
            numberNames.Add(90, "Ninety");
            numberNames.Add(100, "Hundred");
            numberNames.Add(1000, "Thousand");
            numberNames.Add(1000000, "Million");
            numberNames.Add(1000000000, "Billion");
            


            // Max num: 2147483648
            string words = "";
            string strNum = num.ToString();
            int digits = strNum.Length;


            int ones;
            int tens;
            int hundreds;
            int thousandOnes;
            int thousandTens;
            int thousandHundreds;
            int millionOnes;
            int millionTens;
            int millionHundreds;
            int billionOnes;

            if (digits == 10) // Billion 0 - 9,999,999,999 (Done)
            {
                ones = Int32.Parse(strNum[9].ToString());
                tens = Int32.Parse(strNum[8].ToString());
                hundreds = Int32.Parse(strNum[7].ToString());
                thousandOnes = Int32.Parse(strNum[6].ToString());
                thousandTens = Int32.Parse(strNum[5].ToString());
                thousandHundreds = Int32.Parse(strNum[4].ToString());
                millionOnes = Int32.Parse(strNum[3].ToString());
                millionTens = Int32.Parse(strNum[2].ToString());
                millionHundreds = Int32.Parse(strNum[1].ToString());
                billionOnes = Int32.Parse(strNum[0].ToString());

                // Calculating values for tens and thousand tens. (0 represents the digits being calculated.)
                int millionNum = millionTens * 10 + millionOnes; // X00, XXX, XXX
                int thousandNum = thousandTens * 10 + thousandOnes; // X00, XXX
                int tenNum = tens * 10 + ones; // XXX, X00


                // GG
                words += $"{numberNames[billionOnes]} {numberNames[1000000000]}{(millionHundreds > 0 ? $" {numberNames[millionHundreds]} {numberNames[100]}{(millionNum == 0 ? " "+numberNames[1000000] : "")}" : "")}{(millionNum >= 1 && millionNum <= 20 ? $" {numberNames[millionNum]}" : $"{(millionTens == 0 ? "" : $" {numberNames[millionTens * 10]}")}{(millionOnes != 0 ? $" {numberNames[millionOnes]}" : "")}")}{(millionOnes > 0? $" {numberNames[1000000]}":"")}{(thousandHundreds > 0 ? $" {numberNames[thousandHundreds]} {numberNames[100]}{(thousandNum == 0 ? " " + numberNames[1000] : "")}" : "")}{(thousandNum >= 1 && thousandNum <= 20 ? $" {numberNames[thousandNum]} {numberNames[1000]}" : (thousandOnes == 0 ? (thousandTens > 0 ? $" {numberNames[thousandTens * 10]} {numberNames[1000]}" : "") : $" {numberNames[thousandTens * 10]} {numberNames[thousandOnes]} {numberNames[1000]}"))}{(hundreds != 0 ? " " + numberNames[hundreds] + " " + numberNames[100]: "")}{(tenNum >= 1 && tenNum <= 20 ? " " + numberNames[tenNum] : (ones == 0 ? (tens > 0 ? " " + numberNames[tens * 10] : "") : " " + numberNames[tens * 10] + " " + numberNames[ones]))}";
            } 
            else if (digits >= 7 && digits <= 9) // Million
            {
                
                if (digits == 9) // 0 - 999,999,999
                {
                    ones = Int32.Parse(strNum[8].ToString());
                    tens = Int32.Parse(strNum[7].ToString());
                    hundreds = Int32.Parse(strNum[6].ToString());
                    thousandOnes = Int32.Parse(strNum[5].ToString());
                    thousandTens = Int32.Parse(strNum[4].ToString());
                    thousandHundreds = Int32.Parse(strNum[3].ToString());
                    millionOnes = Int32.Parse(strNum[2].ToString());
                    millionTens = Int32.Parse(strNum[1].ToString());
                    millionHundreds = Int32.Parse(strNum[0].ToString());

                    // Calculating values for tens and thousand tens. (0 represents the digits being calculated.)
                    int millionNum = millionTens * 10 + millionOnes; // X00, XXX, XXX
                    int thousandNum = thousandTens * 10 + thousandOnes; // X00, XXX
                    int tenNum = tens * 10 + ones; // XXX, X00


                    // Oof
                    words += $"{numberNames[millionHundreds]} {numberNames[100]}{(millionNum >= 1 && millionNum <= 20 ? $" {numberNames[millionNum]}" : $"{(millionTens==0? "" : $" {numberNames[millionTens * 10]}")}{(millionOnes != 0 ? $" {numberNames[millionOnes]}" : "")}")} {numberNames[1000000]}{(thousandHundreds > 0 ? $" {numberNames[thousandHundreds]} {numberNames[100]}{(thousandNum == 0 ? " " + numberNames[1000] : "")}" : "")}{(thousandNum >= 1 && thousandNum <= 20 ? $" {numberNames[thousandNum]} {numberNames[1000]}" : (thousandOnes == 0 ? (thousandTens > 0 ? $" {numberNames[thousandTens * 10]} {numberNames[1000]}" : "") : $" {numberNames[thousandTens * 10]} {numberNames[thousandOnes]} {numberNames[1000]}"))}{(hundreds != 0 ? " " + numberNames[hundreds] + " " + numberNames[100]: "")}{(tenNum >= 1 && tenNum <= 20 ? " " + numberNames[tenNum] : (ones == 0 ? (tens > 0 ? " " + numberNames[tens * 10] : "") : " " + numberNames[tens * 10] + " " + numberNames[ones]))}";
                }
                else if (digits == 8) // 0 - 99,999,999
                {
                    ones = Int32.Parse(strNum[7].ToString());
                    tens = Int32.Parse(strNum[6].ToString());
                    hundreds = Int32.Parse(strNum[5].ToString());
                    thousandOnes = Int32.Parse(strNum[4].ToString());
                    thousandTens = Int32.Parse(strNum[3].ToString());
                    thousandHundreds = Int32.Parse(strNum[2].ToString());
                    millionOnes = Int32.Parse(strNum[1].ToString());
                    millionTens = Int32.Parse(strNum[0].ToString());// If there are 8 digits, this will never be 0.

                    // Calculating values for tens and thousand tens. (0 represents the digits being calculated.)
                    int millionNum = millionTens * 10 + millionOnes; // 00, XXX, XXX
                    int thousandNum = thousandTens * 10 + thousandOnes; // X00, XXX
                    int tenNum = tens * 10 + ones; // XXX, X00


                    // Oh my...
                    words += $"{(millionNum >= 1 && millionNum <= 20 ? numberNames[millionNum] : $"{numberNames[millionTens * 10]}{(millionOnes != 0 ? $" {numberNames[millionOnes]}" : "")}")} {numberNames[1000000]}{(thousandHundreds > 0 ? $" {numberNames[thousandHundreds]} {numberNames[100]}{(thousandNum == 0 ? " " + numberNames[1000] : "")}" : "")}{(thousandNum >= 1 && thousandNum <= 20 ? $" {numberNames[thousandNum]} {numberNames[1000]}" : (thousandOnes == 0 ? (thousandTens > 0 ? $" {numberNames[thousandTens * 10]} {numberNames[1000]}" : "") : $" {numberNames[thousandTens * 10]} {numberNames[thousandOnes]} {numberNames[1000]}"))}{(hundreds != 0 ? " " + numberNames[hundreds] + " " + numberNames[100]: "")}{(tenNum >= 1 && tenNum <= 20 ? " " + numberNames[tenNum] : (ones == 0 ? (tens > 0 ? " " + numberNames[tens * 10] : "") : " " + numberNames[tens * 10] + " " + numberNames[ones]))}";
                }
                else if(digits == 7) // 0 - 9,999,999 (Done)
                {
                    ones = Int32.Parse(strNum[6].ToString());
                    tens = Int32.Parse(strNum[5].ToString());
                    hundreds = Int32.Parse(strNum[4].ToString());
                    thousandOnes = Int32.Parse(strNum[3].ToString());
                    thousandTens = Int32.Parse(strNum[2].ToString());
                    thousandHundreds = Int32.Parse(strNum[1].ToString()); 
                    millionOnes = Int32.Parse(strNum[0].ToString());// If there are 7 digits, this will never be 0.

                    // Calculating values for tens and thousand tens. (0 represents the digits being calculated.)     
                    int thousandNum = thousandTens * 10 + thousandOnes; // X00, XXX
                    int tenNum = tens * 10 + ones; // XXX, X00


                    // Wow
                    words += $"{numberNames[millionOnes]} {numberNames[1000000]}{(thousandHundreds > 0 ? $" {numberNames[thousandHundreds]} {numberNames[100]}{(thousandNum == 0 ? " "+numberNames[1000] : "")}" : "")}{(thousandNum >= 1 && thousandNum <= 20 ? $" {numberNames[thousandNum]} {numberNames[1000]}" : (thousandOnes == 0 ? (thousandTens > 0 ? $" {numberNames[thousandTens * 10]} {numberNames[1000]}" : "") : $" {numberNames[thousandTens * 10]} {numberNames[thousandOnes]} {numberNames[1000]}"))}{(hundreds != 0 ? " " + numberNames[hundreds] + " " + numberNames[100]: "")}{(tenNum >= 1 && tenNum <= 20 ? " " + numberNames[tenNum] : (ones == 0 ? (tens > 0 ? " " + numberNames[tens * 10] : "") : " " + numberNames[tens * 10] + " " + numberNames[ones]))}";
                }


            }
            else if (digits <= 6 && digits >= 4) // Thousand (need to add more conditions.)
            {

                if (digits == 6) // 0 - 999,999 (Done)
                {
                    ones = Int32.Parse(strNum[5].ToString());
                    tens = Int32.Parse(strNum[4].ToString());
                    hundreds = Int32.Parse(strNum[3].ToString());
                    thousandOnes = Int32.Parse(strNum[2].ToString());
                    thousandTens = Int32.Parse(strNum[1].ToString());
                    thousandHundreds = Int32.Parse(strNum[0].ToString()); // If there are 6 digits, this will never be 0.

                    // Calculating values for tens and thousand tens. (0 represents the digits being calculated.)     
                    int thousandNum = thousandTens * 10+thousandOnes; // X00, XXX
                    int tenNum = tens * 10 + ones; // XXX, X00

                    // Phew
                    words += $"{numberNames[thousandHundreds]} {numberNames[100]}{(thousandNum >= 1 && thousandNum <= 20 ? " "+numberNames[thousandNum] : (thousandOnes == 0 ? (thousandTens> 0 ? " " + numberNames[thousandTens * 10] : "") : " " + numberNames[thousandTens * 10] + " " + numberNames[thousandOnes]))} {numberNames[1000]}{(hundreds != 0 ? " "+numberNames[hundreds] + " " + numberNames[100]: "")}{(tenNum >= 1 && tenNum <= 20 ? " " + numberNames[tenNum] : (ones == 0 ? (tens > 0 ? " " + numberNames[tens * 10] : "") : " " + numberNames[tens * 10] + " " + numberNames[ones]))}";
                }
                else if (digits == 5) // 0 - 99,999 (Done)
                {
                    ones = Int32.Parse(strNum[4].ToString());
                    tens = Int32.Parse(strNum[3].ToString());
                    hundreds = Int32.Parse(strNum[2].ToString());
                    thousandOnes = Int32.Parse(strNum[1].ToString());
                    thousandTens = Int32.Parse(strNum[0].ToString()); // If there are 5 digits, this will never be 0.

                    // Calculating values for tens and thousand tens. (0 represents the digits being calculated.)     
                    int thousandNum = thousandTens * 10 + thousandOnes; // X00, XXX
                    int tenNum = tens * 10 + ones; // X,X00
                    
                    // Magic: 
                    words += $"{(thousandNum >= 10 && thousandNum <= 20 ? numberNames[thousandNum] : (thousandOnes!=0 ? numberNames[thousandTens*10] + " " + numberNames[thousandOnes] : numberNames[thousandTens * 10]))} {numberNames[1000]}{(hundreds != 0 ? " "+numberNames[hundreds] + " "+ numberNames[100] : "")}{(tenNum >= 1 && tenNum <= 20 ? " "+numberNames[tenNum] : (ones == 0 ? (tens >0 ? " " + numberNames[tens * 10] : "") : " " + numberNames[tens * 10] + " " + numberNames[ones]))}";
                }
                else if (digits == 4) // 0 - 9,999 (Done)
                {
                    ones = Int32.Parse(strNum[3].ToString());
                    tens = Int32.Parse(strNum[2].ToString());
                    hundreds = Int32.Parse(strNum[1].ToString());
                    thousandOnes = Int32.Parse(strNum[0].ToString()); // If there are 4 digits, this will never be 0.

                    // Calculating values for tens. (0 represents the digits being calculated.)     
                    int tenNum = tens * 10 + ones; // X,X00

                    // Shazam: 
                    words += $"{numberNames[thousandOnes]} {numberNames[1000]}{(hundreds > 0 ? " " + numberNames[hundreds] + " " + numberNames[100] : "")}{(tenNum >= 1 && tenNum <= 20 ? $" {numberNames[tenNum]}" : (ones == 0 ? (tens > 0 ? $" {numberNames[tens * 10]}" : "") : " "+numberNames[tens * 10] + " " + numberNames[ones]))}";
                }
            }
            else if (digits == 3) // If number has 3 digits. (Done)
            {

                ones = Int32.Parse(strNum[2].ToString());
                tens = Int32.Parse(strNum[1].ToString());
                hundreds = Int32.Parse(strNum[0].ToString());
                // Adds tens and ones to create the 2 digit number.
                int tenNum = tens * 10 + ones;
                
                words += (tenNum >= 1 && tenNum <= 20) ? $"{numberNames[hundreds]} {numberNames[100]} {numberNames[tenNum]}" : (tenNum >= 21) ? $"{numberNames[hundreds]} {numberNames[100]} {(tens != 0 ? $"{numberNames[tens * 10]}{(ones != 0 ? $" {numberNames[ones]}" : "")}" : "")}" : $"{numberNames[hundreds]} {numberNames[100]}";
            }
            else if (digits == 2) // If number has 2 digits (Done)
            {
                // 0 to 99.
                // When number is from 0 to 20, will use dictionary values.
                // If number is bigger than 21, Will use tens and ones. Example : Forty Two. tens = 4, ones = 2
                // If number is from 0 to 20, use the dictionary names. Else, create number names.
                ones = Int32.Parse(strNum[1].ToString());
                tens = Int32.Parse(strNum[0].ToString());

                words += (num >= 0 && num <= 20) ? numberNames[num] : (tens != 0 ? $"{numberNames[tens * 10]}{(ones != 0 ? $" {numberNames[ones]}": "")}": "");
            }
            else if (digits == 1) // If number has 1 digit, use dictionary without calculations. (Easy money baby)
            {
                // 0 to 9
                words += numberNames[num];
            }

            return words;
        }
    }
}
