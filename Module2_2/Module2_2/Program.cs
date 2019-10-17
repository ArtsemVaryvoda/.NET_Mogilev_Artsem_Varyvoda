using System;

namespace Module2_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your age (It must be Integer)"); 
            string value = Console.ReadLine();
            bool isInteger = Int32.TryParse(value, out int number); //Bool variable to check is value is parsable in Integer or no
            if (isInteger && number > 0 && number < 100) //Age must be >0 and <100 also, and for sure it must me parsable into integer
            {
                if (number > 18 && number % 2 == 0) //Checking for first condition "Если N четное и больше 18 – программа поздравляет его с 18-и летием. "
                    Console.WriteLine("Contragulations, you're adult and your age is odd!");
                else if (13 < number && number < 18 && number % 2 != 0) //Checking for second condition "Если N нечетное и меньше 18 но больше 13 – программа поздравляет с переходом в старшую школу."
                    Console.WriteLine("Congratulations on moving to high school!");
                else
                    Console.WriteLine("Sorry, no contragulations for you :)"); //If age doesn't meet any of above conditions error will appear
            }
            else
                Console.WriteLine("You've entered invalid age or non-integer.");    //If user input non valid value error will appear
        }
    }
}
