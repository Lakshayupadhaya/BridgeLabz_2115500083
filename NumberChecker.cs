using System;

public class NumberChecker
{
    // Method to check if a number is positive or negative
    public static string IsPositive(int number)
    {
        return number < 0 ? "Negative" : "Positive";
    }

    // Method to check if a number is even or odd
    public static string IsEven(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }

    // Method to compare two numbers
    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
            return 1;
        else if (number1 == number2)
            return 0;
        else
            return -1;
    }

    public static void Main(string[] args)
    {
        int[] numbers = new int[5];

        // Taking input for 5 numbers
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Checking positivity/negativity and even/odd for each number
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Number " + (i + 1) + " (" + numbers[i] + ") is " + IsPositive(numbers[i]) + " and " + IsEven(numbers[i]) + ".");
        }

        // Comparing the first and last elements of the array
        int result = Compare(numbers[0], numbers[numbers.Length - 1]);
        if (result == 1)
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else if (result == 0)
        {
            Console.WriteLine("The first and last numbers are equal.");
        }
        else
        {
            Console.WriteLine("The first number is less than the last number.");
        }
    }
}
