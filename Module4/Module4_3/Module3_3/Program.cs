/*
3 А. IncrementalBy10 method
3 Б. CircleLengthArea method
3 В. ArrayMaxMinSum method
*/
using System;

namespace Module3_3
{
    class Program
    {
        static void Main()
        {
            int value1 = 10;
            int value2 = 23;
            int value3 = 9;
            Console.WriteLine($"Before calling method for incremental by 10 values will be: value1 {value1}, value2 {value2}, and value3 {value3}\n");
            IncrementalBy10(ref value1, ref value2, ref value3);
            Console.WriteLine($"After calling method for incremental by 10 values will be: value1 {value1}, value2 {value2}, and value3 {value3}\n");
            double radius = 10;
            CircleLengthArea(radius, out double circleLength, out double circleArea);
            Console.WriteLine($"For the {radius} radius of the Circle it's Length will be {circleLength}, and Area: {circleArea}\n");
            int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Elements of the array are: ");
            foreach (var arrayElement in array)
            {
                Console.Write(arrayElement+" ");
            }
            ArrayMaxMinSum(array, out int maxValue, out int minValue, out int sumOfElements);
            Console.WriteLine($"\nMaximum element in the array: {maxValue}, mininum element {minValue}, sum of all elements: {sumOfElements}");
        }

        static void IncrementalBy10(ref int valueToIncrement1, ref int valueToIncrement2, ref int valueToIncrement3)
        {
            valueToIncrement1 += 10;
            valueToIncrement2 += 10;
            valueToIncrement3 += 10;
        }

        static void CircleLengthArea(double radius, out double circumference, out double area)
        {
            circumference = 2 * Math.PI * radius;
            area = Math.PI * Math.Pow(radius, 2);
        }

        static void ArrayMaxMinSum(int[] array, out int maxValue, out int minValue, out int sumOfElements)
        {
            maxValue = array[0];
            minValue = array[0];
            sumOfElements = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                    minValue = array[i];
                else if (maxValue < array[i])
                    maxValue = array[i];
                sumOfElements += array[i];
            }

        }
    }
}
