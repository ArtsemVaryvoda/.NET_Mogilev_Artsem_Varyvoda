/* Nothing special here 
With the help of temp variable we move previous secondNumber to firstNumber, and secondNumber become sum of the current number in the 
Fibonacci sequence and next number
Also added check for the validness of input value*/
using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Please, type in N (How much Fibonacci numbers to show.)");
        if (Int32.TryParse(Console.ReadLine(), out int nElements) && nElements > 0)
        {
            int firstNumber = 0; //Initial numbers in Fibbonacci sequence
            int secondNumber = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < nElements; i++)
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp + secondNumber;
                Console.WriteLine($"The {i+1} Fibonacci number is {secondNumber}");
            }
        }
        else
            Console.WriteLine("You've entered non-valid Integer, or it's less than one.");
        
    }
}



