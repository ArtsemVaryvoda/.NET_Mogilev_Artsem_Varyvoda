/*For the bisection i used formula from the site
https://clck.ru/JgFAG Nothing special to comment here. Just setting the variables and calculating formula.*/

using System;

namespace Module3_8_2
{
    class Program
    {
        static void Main()
        {
            double x1 = -3;
            double x2 = 7;
            double y1 = -2;
            double y2 = 5;
            double xMiddle = (x1 + x2) / 2;
            double yMiddle = (y1 + y2) / 2;
            Console.WriteLine($"For the coordinates x1: {x1}, x2: {x2}, y1: {y1}, y2: {y2} bisectrice coordinates" +
                $" will be: x: {xMiddle}, y: {yMiddle}");
        }
    }
}
