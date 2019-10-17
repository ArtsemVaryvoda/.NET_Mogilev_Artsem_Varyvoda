/*!!All entered values should be doubles (if number is separated separator must be .)!! Program is not designed to work otherwise.
As far as i understand from the webinar, the purpose of this program is next:
1st step - User input parameters for which figure he want to calculate;
2nd step - Program ask user nessesary parameters to calculate values for the Triangle, Rectangle or Circle.
3rd step - Program calculates actual values.
4th step - After calculations program also calculate and shows values for other figures. For example - if user select Triangle, program will show
circle radius and perimeter, and area and perimeter for Rectangle.*/

using System;

namespace Figures
{
 
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, select needed value from the list \n1 - Triangle. \n2 - Rectangle. \n3 - Circle \n4 - Exit the program"); //User selects figure
            var input = Console.ReadLine();

            switch (input) //Based on user selection will called method for specific figure. If user selects value he can try again, or exit the grogram.
            {
                case "1":
                    RightTriangle();
                    break;
                case "2":
                    Rectangle();
                    break;
                case "3":
                    Circle();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You've entered wrong value. Please, try again.");
                    Main();
                    break;
            }
            
        }
        static void RightTriangle () //Method for Triangle. Also calculates area/perimeter for Rectangle and circle.
        {
            double hypotenuse;
            Console.WriteLine("Please, write value of the first cathet, press Enter, and than value of the second cathet");
            //User have to input only values of both catets, hypotenuse will calculate in method.
            if (Double.TryParse(Console.ReadLine(), out double catet1) && catet1 > 0 && Double.TryParse(Console.ReadLine(), out double catet2) && catet2 > 0)
            {

                hypotenuse = Math.Sqrt(Math.Pow(catet1, 2) + Math.Pow(catet2, 2));


                Console.WriteLine($"Triangle Area is {TriangleArea(catet1, catet2)}");
                Console.WriteLine($"Triangle Perimeter is {TrianglePerimeter(catet1, catet2, hypotenuse)}\n");
                Console.WriteLine("If catet1 is side1 in the Rectangle, and catet2 is side2....");
                Console.WriteLine($"Rectangle Area will be {RectangleArea(catet1, catet2)}");
                Console.WriteLine($"and its Perimeter will be: {RectanglePerimeter(catet1, catet2)}\n");
                Console.WriteLine($"If hypotenuse is radius of the Circle...");
                Console.WriteLine($"Circle Area will be {CircleArea(hypotenuse)}");
                Console.WriteLine($"and it's perimeter will be {CirclePerimeter(hypotenuse)}");
            }
            else //If one/both of the values <=0, or not parsable, error will appear and program will start from the beginning.
            { 
                Console.WriteLine("One of the entered values is incorrect, please try again.");
                Main();
            }
        }

        static void Rectangle() //Method for Rectange. Also calculates area/perimeter for RightTriangle and circle.
        {
            Console.WriteLine("Please, write value of the first side, press Enter, and than value of the second side");
            if (Double.TryParse(Console.ReadLine(), out double side1) && side1 > 0 && Double.TryParse(Console.ReadLine(), out double side2) && side2 > 0)
            {
                Console.WriteLine($"Rectangle Area is {RectangleArea(side1, side2)}");
                Console.WriteLine($"Rectangle Perimeter is {RectanglePerimeter(side1, side2)}\n");
                Console.WriteLine("If side1 is catet1 in the Triangle, and side2 is catet2....");
                Console.WriteLine($"Triangle Area will be {TriangleArea(side1, side2)}");
                Console.WriteLine($"and its Perimeter will be: {TrianglePerimeter(side1, side2, Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2)))}\n");
                Console.WriteLine($"If side1 is radius of the Circle...");
                Console.WriteLine($"Circle Area will be {CircleArea(side1)}");
                Console.WriteLine($"and it's perimeter will be {CirclePerimeter(side1)}");
            }
            else //If one/both of the values <=0, or not parsable, error will appear and program will start from the beginning.
            {
                Console.WriteLine("One of the entered values is incorrect, please try again."); 
                Main();
            }
        }

        static void Circle () //Method for Circle. Also calculates area/perimeter for RightTriangle and Rectangle.
        {
            Console.WriteLine("Please, input radius of the Circle and press Enter.");
            if (Double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            {
                Console.WriteLine($"Area of the circle will be {CircleArea(radius)}");
                Console.WriteLine($"Perimeter of the circle will be {CirclePerimeter(radius)}\n");
                Console.WriteLine($"If radius is equal to the both catets of the Triangle, Triangle Area will be {TriangleArea(radius, radius)}");
                Console.WriteLine($"and its Perimeter will be: {TrianglePerimeter(radius, radius, (Math.Sqrt(Math.Pow(radius, 2))*2))}\n");
                Console.WriteLine($"If radius is equal to the both sides of the Rectangle, Rectangle Area will be {RectangleArea(radius, radius)}");
                Console.WriteLine($"and its Perimeter will be: {RectangleArea(radius,radius)}\n");

            }
            else //If one/both of the values <=0, or not parsable, error will appear and program will start from the beginning.
            {
                Console.WriteLine("Entered radius is incorrect, please try again.");
                Main();
            }

        }


        static double CircleArea(double a) //Method which calculate CircleArea
        {
            return Math.PI * Math.Pow(a, 2);
        }

        static double CirclePerimeter(double a) //Method which calculate CirclePerimeter
        {
            return 2 * Math.PI * a;
        }
        static double TriangleArea(double a, double b) //Method which calculate TriangleArea
        {
            return (1.0 / 2.0) * a * b;
        }

        static double TrianglePerimeter(double a, double b, double c) //Method which calculate TrianglePerimeter
        {
            return a + b + c;
        }

        static double RectangleArea(double a, double b) //Method which calculate RectangleArea
        {
            return a * b;
        }

        static double RectanglePerimeter(double a, double b) //Method which calculate RectanglePerimeter
        {
            return (a + b) * 2;
        }
    }
}