using System;

class Calculator
{
    static void Main()
    {
        // input first number
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        // input second number
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = (number2 != 0) ? number1 / number2 : 0; // Handle division by zero

        // Print the results
        Console.WriteLine("The addition, subtraction, multiplication, and division of {0} and {1} are:", number1, number2);// this can be done without string.Format
        Console.WriteLine("Addition: {0}", addition);
        Console.WriteLine("Subtraction: {0}", subtraction);
        Console.WriteLine("Multiplication: {0}", multiplication);
        Console.WriteLine("Division: {0}", division);
    }
}
