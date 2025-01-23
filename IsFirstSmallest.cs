using System;

class IsFirstSmallest
{
    static void Main()
    {
        // Input three numbers
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the third number: ");
        double number3 = Convert.ToDouble(Console.ReadLine());

        // Check if the first number is the smallest
        bool isSmallest = number1 < number2 && number1 < number3;

        // result
        Console.WriteLine("Is the first number the smallest? " + (isSmallest ? "Yes" : "No"));
    }
}
