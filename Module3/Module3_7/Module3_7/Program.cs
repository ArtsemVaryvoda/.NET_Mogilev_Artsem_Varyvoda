using System;

namespace Module3_7
{
    class Program
    {
        static void Main()
        {
            int[] numbersArray = new int[] {3, 9, 8, 4, 5, 1};  //Array is hardcoded. Values like in task.
            foreach (var value in numbersArray)                 //Printing all array values.
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();                                //For better visiability in the command line
            /*// i< numbersArray.Length-1 because otherwise will be an exception. It doesn't affect program results, 
             even if last number will be greater than previous one last number still be normally shown.*/
            for (int i = 0; i < numbersArray.Length-1; i++)         
            {
                if (numbersArray[i] < numbersArray[i + 1])      //Simple check for the values that greater than previous in the array.
                    Console.WriteLine(numbersArray[i + 1]+" ");
            }
        }
    }
}
