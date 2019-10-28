/*Array is hardcoded.
 1. A ArrayMax method
 1. Б ArrayMax method
 1. B ArraySum method
 1. Г ArrayMaxMinDifference method
 1. Д ArrayOddsAndOdd method*/

using System;


namespace Module3_1
{
    class Program
    {
        static void Main()
        {
            int[] balance = new int[] { 1, -2, 30, 999, -21, 2300, 84, 500, 0 };
            Console.WriteLine($"Max value in the array is:{ArrayMax(balance)}");
            Console.WriteLine($"Miminum value in the array is: {ArrayMin(balance)}");
            Console.WriteLine($"Sum of all elements in the array is: {ArraySum(balance)}");
            Console.WriteLine(ArrayMaxMinDifference(balance));
            ArrayOddsAndOdd(balance);
        }

        static int ArrayMax(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {

                if (array[i] > maxValue)
                    maxValue = array[i];
            }
            return maxValue;
        }

        static int ArrayMin(int[] array)
        {
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {

                if (array[i] < minValue)
                    minValue = array[i];
            }
            return minValue;
        }

        static int ArraySum(int[] array)
        {
            int sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];                
            }
            return sum;
        }

        static int ArrayMaxMinDifference(int[] array)
        {
            int maxValue = array[0];
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {

                if (array[i] > maxValue)
                    maxValue = array[i];
                if (array[i] < minValue)
                    minValue = array[i];
            }
            return maxValue-minValue;
        }

        static int[] ArrayOddsAndOdd(int[] array)
        {
            int maxValue = array[0];
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {

                if (array[i] > maxValue)
                    maxValue = array[i];
                if (array[i] < minValue)
                    minValue = array[i];
            }

            for (int i = 0; i< array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    array[i] = array[i] + maxValue;
                else array[i] = array[i] - minValue;
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }

    }
}


    
