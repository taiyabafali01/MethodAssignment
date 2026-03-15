using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main()
        {
            // Create an object of the MathOperations class
            MathOperations math = new MathOperations();

            // Call the method with two numbers
            math.DoMath(10, 20);

            // Call the method again using named parameters
            math.DoMath(firstNumber: 15, secondNumber: 30);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
