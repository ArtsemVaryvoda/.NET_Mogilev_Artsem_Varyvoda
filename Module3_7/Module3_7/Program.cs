using System;


namespace SortApp
{
    class Program
    {
        static void Main()
        {
            int[] arrayToSort = new int[] { 4, 3, 2, 63, 2, -1, 72, 0, 54 };
            Console.WriteLine("Array Before sort.");
            foreach (var item in arrayToSort)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nType in ASC or DESC order of sorting.");
            string input = Console.ReadLine();
            int[] sortedArray = SortArray(arrayToSort, input);
            Console.WriteLine("Array after sort.");
            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] SortArray(int[] arrayToSort, string input)
        {
            int temp;
            if (input == "ASC")
            {
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    for (int j = i + 1; j < arrayToSort.Length; j++)
                    {
                        if (arrayToSort[i] > arrayToSort[j])
                        {
                            temp = arrayToSort[i];
                            arrayToSort[i] = arrayToSort[j];
                            arrayToSort[j] = temp;
                        }
                    }
                }
            }
            else if (input == "DESC")
            {
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    for (int j = i + 1; j < arrayToSort.Length; j++)
                    {
                        if (arrayToSort[i] < arrayToSort[j])
                        {
                            temp = arrayToSort[i];
                            arrayToSort[i] = arrayToSort[j];
                            arrayToSort[j] = temp;
                        }
                    }
                }
            }
            else Console.WriteLine("Input value !=ASC or DESC. Array not sorted");
            return arrayToSort;
        }
    }
}