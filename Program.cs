 using System;

class Program
{
    static void Main()
    {
        // Create an object of the MathOperations class
        MathOperations math = new MathOperations();

        // Ask the user for the first number
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user for the second number (optional)
        Console.WriteLine("Enter the second number (press Enter to skip):");
        string input = Console.ReadLine();

        int result;

        // Check if the user entered a second number
        if (string.IsNullOrEmpty(input))
        {
            // Call the method with only the first number
            result = math.AddNumbers(number1);
        }
        else
        {
            // Convert input to integer
            int number2 = Convert.ToInt32(input);

            // Call the method with two numbers
            result = math.AddNumbers(number1, number2);
        }

        // Display the result
        Console.WriteLine("The result is: " + result);

        Console.ReadKey();
    }
}
