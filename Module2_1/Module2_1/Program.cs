/*In this solution supposed that user inputs Number of companies and tax percentage as Integers.
 No additional checks addes/*/

using System;

namespace Module2_1
{
    class Program
    {
        static void Main()
        {
            double profit = 500.0; //Assigning progit of company (It's equal between all companies)
            Console.WriteLine("Please, Type in how much companies works in the country.");
            int companiesNumber = Int32.Parse(Console.ReadLine()); //Saving input of companies number into companiesNumber variable
            Console.WriteLine("Enter tax percentage in percents. Example: 1, 5 or 30");
            int tax = Int32.Parse(Console.ReadLine()); //Saving input of tax in percents into companiesNumber variable
            double totalTax = ((profit * (double)companiesNumber) * ((double)tax / (double) 100));
            Console.WriteLine($"Totally government will receive {totalTax}$ of taxes.");
        }
    }
}
