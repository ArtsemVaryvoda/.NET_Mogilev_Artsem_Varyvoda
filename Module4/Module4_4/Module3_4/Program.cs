/* 
4 А. IncrementalBy10 method method
4 Б. CircleCircumferenceArea method
4 В. ArrayMaxMinSum method
It was interesting task, learn a lot about tuples :)
*/
using System;

namespace Module3_4
{
    class Program
    {
        static void Main()
        {
            int firstValue = 10;
            int secondValue = 15;
            int thirdValue = 23;
            Console.WriteLine($"For now values is: {firstValue}, {secondValue}, {thirdValue}");
            var tuple = IncrementalBy10(firstValue, secondValue, thirdValue);
            Console.WriteLine($"If we use method IncrementalBy10, tuple elements will be {tuple.Item1}, {tuple.Item2}, {tuple.Item3}\n");
            double radius = 10;
            var (circumference, area) = CircleCircumferenceArea(radius);
            Console.WriteLine($"For the {radius} radius of the Circle it's Length will be {circumference}, and Area: {area}\n");
            int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Elements of the array are: ");
            foreach (var arrayElement in array)
            {
                Console.Write(arrayElement + " ");
            }
            var (maxValue, minValue, sumOfElements) = ArrayMaxMinSum(array);
            Console.WriteLine($"\nMaximum element in the array: {maxValue}, mininum element {minValue}, sum of all elements: {sumOfElements}");
        }

        public static (int, int, int) IncrementalBy10(int value1, int value2, int value3)
        {
            var result = (value1 + 10, value2 + 10, value3 + 10);
            return result;
        }

        public static (double circumference, double area) CircleCircumferenceArea(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            var result = (circumference, area);
            return result;
        }

        static (int maxValue, int minValue, int sumOfElements) ArrayMaxMinSum(int[] array)
        {
            int maxValue = array[0];
            int minValue = array[0];
            int sumOfElements = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                    minValue = array[i];
                else if (maxValue < array[i])
                    maxValue = array[i];
                sumOfElements += array[i];
            }

            var result = (maxValue, minValue, sumOfElements);
            return result;
        }
    }
}
