/*It's not quite understandable from the task what to do, as a template i used this article
 https://x-engineer.org/undergraduate-engineering/advanced-mathematics/numerical-methods/the-bisection-method-for-root-finding/ */

using System;

class BisectionAlgorithm
{
    static readonly float epsilon = (float)0.01; //defining tolerance when algoritm will end.

    static public void Main()
    {
        Console.WriteLine("Input value of the dot a. It must be double.");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input value of the dot b. It must be double.");
        double b = Convert.ToDouble(Console.ReadLine());
        Bisection(a, b);
    }

    static double Function(double x)
    {
        return x * x * x -
            x * x + 2;
    }

    static void Bisection(double a,  double b)
    {
        if (Function(a) * Function(b) >= 0) //In bissectrice a should be 
        {
            Console.WriteLine("You have not assumed right a and b");
            return;
        }

        double c = a;
        while ((b - a) >= epsilon)
        {
            c = (a + b) / 2; 
            if (Function(c) == 0.0)                            // Check if middle point is root 
                break;
            else if (Function(c) * Function(a) < 0)           // Decide the side to repeat the steps 
                b = c;
            else
                a = c;
        }

        Console.WriteLine("The value of root is : " + c);     // prints value of c
    }


}

