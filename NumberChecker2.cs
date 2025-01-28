using System;

public class NumberChecker2
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        string numberString = number.ToString();
        int[] digits = new int[numberString.Length];
        
        for (int i = 0; i < numberString.Length; i++)
        {
            digits[i] = int.Parse(numberString[i].ToString());
        }

        return digits;
    }

    // Method to find the sum of the digits of a number using the digits array
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of the squares of the digits using the digits array
    public static double SumOfSquaresOfDigits(int[] digits)
    {
        double sumOfSquares = 0;
        foreach (int digit in digits)
        {
            sumOfSquares += Math.Pow(digit, 2);
        }
        return sumOfSquares;
    }

    // Method to check if the number is a Harshad number
    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sumOfDigits = SumOfDigits(digits);
        return number % sumOfDigits == 0;
    }

    // Method to find the frequency of each digit in the number
    public static void FindDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2]; // To store digit and its frequency
        for (int i = 0; i < digits.Length; i++)
        {
            frequency[digits[i], 0] = digits[i];
            frequency[digits[i], 1]++;
        }

        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine("Digit: " + frequency[i, 0] + ", Frequency: " + frequency[i, 1]);
            }
        }
    }

    public static void Main(string[] args)
    {
        int number = 21; // Example number

        // Store digits
        int[] digits = StoreDigits(number);

        // Count digits
        Console.WriteLine("Count of digits: " + CountDigits(number));

        // Sum of digits
        Console.WriteLine("Sum of digits: " + SumOfDigits(digits));

        // Sum of squares of digits
        Console.WriteLine("Sum of squares of digits: " + SumOfSquaresOfDigits(digits));

        // Harshad number check
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number, digits));

        // Find digit frequency
        FindDigitFrequency(digits);
    }
}
