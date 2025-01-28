using System;

public class NumberChecker3
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

    // Method to reverse the digits array
    public static int[] ReverseDigits(int[] digits)
    {
        Array.Reverse(digits);
        return digits;
    }

    // Method to compare two arrays and check if they are equal
    public static bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }
        return true;
    }

    // Method to check if a number is a palindrome using the digits array
    public static bool IsPalindrome(int[] digits)
    {
        int[] reversedDigits = ReverseDigits((int[])digits.Clone());
        return CompareArrays(digits, reversedDigits);
    }

    // Method to check if a number is a duck number using the digits array
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true; // If there's a non-zero digit, it's a duck number
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        int number = 121; // Example number

        // Store digits
        int[] digits = StoreDigits(number);

        // Count digits
        Console.WriteLine("Count of digits: " + CountDigits(number));

        // Check if the number is a palindrome
        Console.WriteLine("Is Palindrome: " + (IsPalindrome(digits) ? "Yes" : "No"));

        // Check if the number is a duck number
        Console.WriteLine("Is Duck Number: " + (IsDuckNumber(digits) ? "Yes" : "No"));

        // Reverse the digits array and print
        int[] reversedDigits = ReverseDigits((int[])digits.Clone());
        Console.WriteLine("Reversed Digits: " + string.Join(", ", reversedDigits));

        // Compare the digits array with its reverse
        Console.WriteLine("Is the number a palindrome? " + (CompareArrays(digits, reversedDigits) ? "Yes" : "No"));
    }
}
