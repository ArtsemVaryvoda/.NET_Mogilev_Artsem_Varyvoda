/*The main idea of solution is that we need additional variable, to store value of a. It will be "temporary"
After assigning of a to temporary,we set a = b, and then b = temporary (in temporary stored value of the a).
Swap completed*/


using System; //System library for the Console.WriteLine() 

namespace Module1_1
{
    class Program
    {
        static void Main()
        {
            int a = 1; //assigning initial 1 to the a
            int b = 2; //assigning initial 2 to the b
            int temporary = a; // for the swap of a and b temporary variable is used. 
            Console.WriteLine($"Value of the a before swap is: {a}");
            Console.WriteLine($"Value of the b before swap is: {b}\n");
            a = b;
            b = temporary;
            Console.WriteLine($"Value of the a after swap is: {a}");
            Console.WriteLine($"Value of the b after swap is: {b}");

        }
    }
}
