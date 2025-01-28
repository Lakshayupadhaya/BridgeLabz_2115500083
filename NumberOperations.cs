using System;

public class NumberOperations
{
    // Method to find the count of digits in a number
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

    // Method to check if the number is a Duck number (has a non-zero digit)
    public static bool IsDuckNumber(int number)
    {
        return number.ToString().Contains("0");
    }

    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = 0;
        int length = digits.Length;

        foreach (var digit in digits)
        {
            sum += (int)Math.Pow(digit, length);
        }

        return sum == number;
    }

    // Method to find the largest and second largest digits
    public static void FindLargestAndSecondLargest(int[] digits)
    {
        int largest = -1, secondLargest = -1;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }

        Console.WriteLine("Largest: {0}, Second Largest: {1}", largest, secondLargest);
    }

    // Method to find the smallest and second smallest digits
    public static void FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = 10, secondSmallest = 10;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }

        Console.WriteLine("Smallest: {0}, Second Smallest: {1}", smallest, secondSmallest);
    }

    public static void Main(string[] args)
    {
        int number = 153; // Example number to test

        // Count digits
        Console.WriteLine("Count of digits: " + CountDigits(number));

        // Store digits
        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // Duck number check
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(number));

        // Armstrong number check
        Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(number));

        // Find largest and second largest
        FindLargestAndSecondLargest(digits);

        // Find smallest and second smallest
        FindSmallestAndSecondSmallest(digits);
    }
}
