using System;

class SwapTwoNum
{
    static void Main()
    {
        // input two numbers from user
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swap the numbers using a temporary variable
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Display the swapped values
        Console.WriteLine("The swapped numbers are {0} and {1}.", number1, number2);
    }
}
