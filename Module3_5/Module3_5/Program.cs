using System;

namespace Module3_5
{
    class Program
    {
        public enum MathOperations
        {
            PLUS,
            MINUS,
            MULTIPLY,
            DIVIDE
        };


        public enum DAYS_IN_MONTHS
        {
            January = 31,
            February = 28,
            FebruaryLeap = 29,
            March = 31,
            April = 30,
            May = 31,
            June = 30,
            July = 31,
            August = 31,
            September = 30,
            October = 31,
            November = 30,
            December = 31
        };
        static void Main()
        {
            Console.WriteLine($"In the February will be {(int)DAYS_IN_MONTHS.February} days");
            Console.WriteLine($"In the February of a leap year will be {(int)DAYS_IN_MONTHS.FebruaryLeap} days");
            Console.WriteLine($"In the July will be {(int)DAYS_IN_MONTHS.July} days");

            Console.WriteLine("The sum of 5 and 5 is " + Calculate(5, 5, MathOperations.PLUS));
            Console.WriteLine("5 minus 5 will be " + Calculate(5, 5, MathOperations.MINUS));
            Console.WriteLine("The multiplication of 5 and 5 is " + Calculate(5, 5, MathOperations.MULTIPLY));
            Console.WriteLine("The division of 5 and 5 is " + Calculate(5, 5, MathOperations.DIVIDE));

        }

        public static double Calculate(int firstNumber, int secondNumber, MathOperations Operator)
        {

            int i = (int)Operator;

            switch (i)
            {
                case 0:
                    {
                        return firstNumber + secondNumber;
                    }

                case 1:
                    {
                        return firstNumber - secondNumber;
                    }

                case 2:
                    {
                        return firstNumber * secondNumber;
                    }

                case 3:
                    {
                        return firstNumber / secondNumber;
                    }

                default:
                    {
                        return 0.0;
                    }
            }
        }
    }
}

