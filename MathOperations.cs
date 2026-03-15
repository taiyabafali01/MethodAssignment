using System;

namespace MethodAssignment
{
    // This class contains the method for the assignment
    class MathOperations
    {
        // This void method takes two integers
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = firstNumber * 2;

            // Display the result
            Console.WriteLine("Result of first number: " + result);

            // Display the second integer
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}
