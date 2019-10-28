/*The biggest problem for me in this task was checking if int in the Array == to the int that we need to Detele.
Firstly task was designed like 4th task, Array was in char, but if i convert value that need to be deleted from array in char,
and compare it with array it's some problems. If Console.WriteLine shows that both values are 5, for some reason there values aren't ==.
In general - interesting task*/

using System;
using System.Linq;

namespace Module3_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type in Natural Number");
            if (Int32.TryParse(Console.ReadLine(), out int naturalNumber))
            {
                Console.WriteLine("Type in number that will be deteled.");
            }
            else
            {
                Console.WriteLine("Inputed value isn't Integer. Program exit.");
                return;
            }
            if (Int32.TryParse(Console.ReadLine(), out int numberToDelete) && numberToDelete >=0 && numberToDelete <10)
            {
                //Converting naturalNumber to int[] Array with the help of Linq
                int[] naturalNumberInArray = naturalNumber.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray(); 
                string numberWithoutDigit = ""; //temporary variable 
                //Checking if element of the array == to the number that we need to delete. If not we add number to the array.
                for (int i = 0; i < naturalNumberInArray.Length; i++)
                {
                    if (naturalNumberInArray[i] != numberToDelete)
                        numberWithoutDigit += naturalNumberInArray[i].ToString();
                }
                int resultNumber = Int32.Parse(numberWithoutDigit);
                Console.WriteLine($"Natural number {naturalNumber} without digit {numberToDelete} will be {resultNumber}");
            }
            else
                Console.WriteLine("Inputed value isn't Integer. Program exit.");
        }
    }
}
