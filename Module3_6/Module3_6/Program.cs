/*Sorry for a lack of comments, but it's nothing interesting to write about. Code should be clear*/

using System;

namespace Module3_6
{
    class Program
    {
        static void Main()
        {
            int[] initialArray = new int[] {1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10};
            Console.WriteLine("Before incrementing array elements are:");
            foreach (var arrayElement in initialArray)
            {
                Console.Write(arrayElement+" ");
            }
            int[] arrayAfterIncrement = ArrayIncrementElementsBy5(initialArray);
            Console.WriteLine("\nAfter incrementing array elements are:");
            foreach (var arrayElement in arrayAfterIncrement)
            {
                Console.Write(arrayElement + " ");
            }
        }
        static int[] ArrayIncrementElementsBy5(int[] incrementedArray)
        {
            for (int i = 0; i < incrementedArray.Length; i++)
            {
                incrementedArray[i] += 5;
            }
            return incrementedArray;
        }
    }
}
