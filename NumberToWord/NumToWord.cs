using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    internal class NumToWord
    {
        public static string numberToWord()
        {
            // string[] TwoDig = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            //string[] unit = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] unit = { " zero"," one", " two", " three", " four", " five", " six", " seven", " eight", " nine" };
            string[] tens = {  ""," ten", " twenty", " thirty", " fourty", " fifty", " sixty", " seventy", " eighty", " ninety" };
            string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string a = Console.ReadLine();


            char[] array = a.ToCharArray();

           if (array.Length == 1)
            {
               
                double single = Char.GetNumericValue(array[0]);
               
                int Single = Convert.ToInt32(single);


                //Console.WriteLine(hundred + " hundred");
                Console.WriteLine( unit[Single]);
            }

            if (array.Length == 2)
            {
                double ten = Char.GetNumericValue(array[0]);
                double single = Char.GetNumericValue(array[1]);
                int Tens = Convert.ToInt32(ten);
                int Single = Convert.ToInt32(single);

                if (Tens > 0 & single == 0)
                {
                    Console.WriteLine(tens[Tens]);

                }

                else
                {
                    if (Tens == 1 & Single >= 0)
                    {

                        Console.WriteLine(teens[Single]);
                    }
                    else
                    {

                        //Console.WriteLine(hundred + " hundred");
                        Console.WriteLine(tens[Tens] + unit[Single]);
                    }
                }
            }
            
            
            
            if (array.Length == 3)
            {
                double hundred1 = Char.GetNumericValue(array[0]);
                double ten = Char.GetNumericValue(array[1]);
                double single = Char.GetNumericValue(array[2]);

                int hundred = Convert.ToInt32(hundred1);
                int Tens = Convert.ToInt32(ten);
                int Single = Convert.ToInt32(single);

                if (Tens > 0 & single == 0)
                {
                    Console.WriteLine(unit[hundred] + " hundred " + tens[Tens]);

                }

                else
                {
                    if (Tens == 1 & Single >= 0)
                    {
                        //Console.WriteLine(hundred + " hundred");
                        Console.WriteLine(unit[hundred] + " hundred " + teens[Single]);
                    }
                    else
                    {

                        Console.WriteLine(unit[hundred] + " hundred " + tens[Tens] + unit[Single]);
                    }
                }
            
            
            }

           if (array.Length==4)
            { 
                double thousand = Char.GetNumericValue(array[0]);
                double hundred1 = Char.GetNumericValue(array[1]);
                double ten = Char.GetNumericValue(array[2]);
                double single= Char.GetNumericValue(array[3]);

                int Thousand = Convert.ToInt32(thousand);
                int hundred = Convert.ToInt32(hundred1);
                int Tens = Convert.ToInt32(ten);
                int Single = Convert.ToInt32(single);

                if (Tens > 0 & single == 0)
                {
                    Console.WriteLine(unit[Thousand] + " thousand " + unit[hundred] + " hundred " + tens[Tens]);

                }


                else
                {
                    if (Tens == 1 & Single >= 0)
                    {
                        //Console.WriteLine(hundred + " hundred");
                        Console.WriteLine(unit[Thousand] + " thousand " + unit[hundred] + " hundred " + teens[Single]);

                    }

                    else
                    {
                        //Console.WriteLine(hundred + " hundred");
                        Console.WriteLine(unit[Thousand] + " Thousand" + unit[hundred] + " Hundred" + tens[Tens] + unit[Single]);
                    }
                }
            }
            return "";








        }
    }
}
