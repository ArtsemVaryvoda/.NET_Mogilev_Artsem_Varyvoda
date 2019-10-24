using System;

namespace Module2_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type in first number.");
            var input1 = Console.ReadLine(); //Setting first number
            Console.WriteLine("Type in second number.");
            var input2 = Console.ReadLine(); //Setting second number
            /*In the variables , replaced with .
            It's made because in the CIS encoding decimals separated with .
            It's made because user can type 2,33 or 2.33*/
            input1 = input1.Replace(',', '.'); 
            input2 = input2.Replace(',', '.');
            if (decimal.TryParse(input1, out decimal decimal1) && decimal.TryParse(input2, out decimal decimal2)) //Check that both variables parsable as decimals
            {
                ChangeDecimal(decimal1, decimal2);
            }
            else
            {
                Console.WriteLine("Sorry, you've entered wrong numbers. If you want to try again press Y and Enter. Exit - Q and Enter");
                WrongValue();
            }

        }
        

        static void ChangeDecimal(decimal decimal1, decimal decimal2)
        {
            decimal temporary = decimal1;
            Console.WriteLine($"Before swap first value is {decimal1}, and second value is {decimal2}");
            decimal1 = decimal2;
            decimal2 = temporary;
            Console.WriteLine($"After swap first value becomes {decimal1}, and second value becomes {decimal2}");
            System.Environment.Exit(1); //Because the numbers are reversed we can exit the program 

        }

        static void WrongValue() //Method called if user inputes wrong values (non-numbers). User can try again, or exit the program.
        {
            var check = Console.ReadLine();
            if (check == "Y")
                Main();
            else if (check == "Q")
                return;
            else
                Console.WriteLine("You've entered not Y or Q");
                WrongValue();
        }
    }
}
        