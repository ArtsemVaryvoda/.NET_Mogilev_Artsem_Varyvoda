/*Input array is hardcoded, feel free to change it for the testing purposes.
Firstly prints all values of the array.
Then in the for statement each value of the array is proceeded. If value > 0 it's multiplicating on -1 and becomes negative.
If value < 0 Math.Abs used, and negative value becomes positive.
If value == 0 nothing happens.
In the end all values in the array printed to see result of the program*/

using System;

namespace Module3_6
{
    class Program
    {
        static void Main()
        {
            int[] arrayToChange = new int[] { 0, 1, -1, 837, -100, 904, -541 };
            Console.WriteLine("Initial array is: ");
            foreach (int arrayElement in arrayToChange)
            {
                Console.Write(arrayElement + " ");
            }
            for (int i = 0; i < arrayToChange.Length; i++)
            {
                if (arrayToChange[i] > 0)
                    arrayToChange[i] *= -1;
                else if (arrayToChange[i] < 0)
                    arrayToChange[i] = Math.Abs(arrayToChange[i]);
            }
            Console.WriteLine("\nAfter change array is: ");
            foreach (int arrayElement in arrayToChange)
            {
                Console.Write(arrayElement + " ");
            }
        }
    }
}
