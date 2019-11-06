/*Inputed value checking for parse in double, if it's not parsable program closed with error.*/

using System;

namespace Module3_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, type in decimal that will be inverted");
            if (Double.TryParse(Console.ReadLine(), out double initialNumber))
            {
                Console.WriteLine("Initial value is: {0}", initialNumber);
                string invertedNumberTemp = "";
                char[] digits = initialNumber.ToString().ToCharArray();          //Inputed value converting to the char array
                char[] digitsDesc = new char[digits.Length];                     //Creating of the temp array, where we inverting places
                for (int i = 0; i < digits.Length; i++)                          //Values from the end of the initial array set in the start of array with inverted vaues.
                {
                    digitsDesc[digitsDesc.Length - i - 1] = digits[i];
                }       
                foreach (var item in digitsDesc)                                 //Saving array in the String
                {
                    invertedNumberTemp += item;
                }
                double invertedNumber = Double.Parse(invertedNumberTemp);        //Converting string into double value
                Console.WriteLine("Inverted number will be: {0}", invertedNumber);
            }
            else Console.WriteLine("You've entered non-valid value.");
        }
    }
}
