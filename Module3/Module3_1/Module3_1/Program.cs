/*Solution based on loop. First value added to itself for second value times.
If one of values <0 in the end multiplication result will return with - 
If both values >0, or <0, or one of em =0 multiplication result will be positive.
Also added checks that both values are Integers. If one of them none program will exit with error message*/

using System;

namespace Module3_1
{
    class Program
    {
        static void Main()
        {
            int multiplicationResult = 0;
            Console.WriteLine("Please, input value of the first integer.");
            bool checkFirstNumber = Int32.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please, input value of the second integer.");
            bool checkSecondNumber = Int32.TryParse(Console.ReadLine(), out int secondNumber);
            if (checkFirstNumber && checkSecondNumber)
            {
                if ((firstNumber > 0 & secondNumber <0) | (firstNumber < 0 & secondNumber > 0))
                {
                    for (int i = 0; i < Math.Abs(secondNumber); i++)
                    {
                        multiplicationResult += Math.Abs(firstNumber);
                    }
                    multiplicationResult *= -1;
                    Console.WriteLine("The result of the multiplication will be: {0}", multiplicationResult);
                }
                else 
                {
                    for (int i = 0; i < Math.Abs(secondNumber); i++)
                    {
                        multiplicationResult += Math.Abs(firstNumber);
                    }
                    Console.WriteLine("The result of the multiplication will be: {0}", multiplicationResult);
                }

            }
            else Console.WriteLine("One or both of inputed values are not integers. Run the program again and input " +
            "correct values");

        }
    }
}
