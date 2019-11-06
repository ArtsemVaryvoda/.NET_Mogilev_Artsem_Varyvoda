/*
2 А Addition3Int
2 Б Addition2Int
2 В Addition3Fractionals
2 Г Concatenation2Strings
2 Д Concatenation2Arrays - as far as i understand from the task Результатом будет сумма a[i] + b[i]., sum is just concatenating two arrays in one.
*/

using System;
using System.Linq;

namespace Module3_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Sum of 3 integers will be:{Addition3Int(2, 3, 5)}\n");
            Console.WriteLine($"Sum of 2 integers will be: {Addition2Int(8, 9)}\n");
            Console.WriteLine($"Sum of 3 fractionals will be: {Addition3Fractionals(1.33, 2.22, 0.15)}\n");
            Console.WriteLine($"Example of Concatenation of 2 string: {Concatenation2Strings("This is string1", "This is string2")}");
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[] {4, 5, 6};
            int[] sumOfArrays = Concatenation2Arrays(array1, array2);
            Console.WriteLine("array1 + array2 will be:");
            foreach (var arrayElement in sumOfArrays)
            {
                Console.Write(arrayElement + " ");
            }
            
        }

        static int Addition3Int(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        static int Addition2Int(int number1, int number2)
        {
            return number1 + number2;
        }

        static double Addition3Fractionals(double number1, double number2, double number3)
        {
            return number1 + number2 + number3;
        }

        static string Concatenation2Strings(string string1, string string2)
        {
            return string.Concat(string1, string2);
        }

        static int[] Concatenation2Arrays(int [] array1, int[] array2)
        {
            int[] arraySum = array1.Concat(array2).ToArray();
            return arraySum;
        }
    }
}
