using System;

public class NumberChecker4
{
    // Method to check if a number is prime
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;

        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }

        return sumOfDigits == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpy(int number)
    {
        int sum = 0;
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }

        return sum == product;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        int temp = number;

        while (temp > 0)
        {
            if (square % 10 != temp % 10)
                return false;

            square /= 10;
            temp /= 10;
        }

        return true;
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzz(int number)
    {
        return (number % 7 == 0 || number % 10 == 7);
    }

    public static void Main()
    {
        int number = 7;  // Example number

        // Check if the number is prime
        Console.WriteLine("Is Prime: " + (IsPrime(number) ? "Yes" : "No"));

        // Check if the number is a neon number
        Console.WriteLine("Is Neon: " + (IsNeon(number) ? "Yes" : "No"));

        // Check if the number is a spy number
        Console.WriteLine("Is Spy: " + (IsSpy(number) ? "Yes" : "No"));

        // Check if the number is an automorphic number
        Console.WriteLine("Is Automorphic: " + (IsAutomorphic(number) ? "Yes" : "No"));

        // Check if the number is a buzz number
        Console.WriteLine("Is Buzz: " + (IsBuzz(number) ? "Yes" : "No"));
    }
}
