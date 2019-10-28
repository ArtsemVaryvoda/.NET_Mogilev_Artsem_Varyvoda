/*Simple task. 
 User must input Integer. 
 If it's not Integer, or <=0 program will exit with error. 
 Otherwise for N times program will add +2 to evenNumber, this way only evenNumber will be calculated.*/

using System;


namespace Module3_2
{
    class Program
    {
        static void Main()
        {
            int evenNumber = 0;
            Console.WriteLine("Please, type in N;");
            if (Int32.TryParse(Console.ReadLine(), out int naturalN) && naturalN > 0)
            {
                for (int i = 0; i < naturalN; i++)
                {
                    Console.WriteLine(evenNumber += 2);
                }
            }
            else Console.WriteLine("You've input wrong Integer, or it's <=0");
        }
    }
}
