using System;

class LeapYear
{
    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        // Check if the year is greater than or equal to 1582 (Gregorian calendar)
        if (year < 1582)
        {
            Console.WriteLine("The program only works for years >= 1582.");
            return false;
        }

        // Leap year condition: divisible by 4 and (not divisible by 100 or divisible by 400)
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return true;
        }

        return false;
    }

    static void Main(string[] args)
    {
        // Take year input from the user
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Check if the year is a leap year
        bool isLeap = IsLeapYear(year);

        // Output the result
        if (isLeap)
        {
            Console.WriteLine("The year " + year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine("The year " + year + " is NOT a Leap Year.");
        }
    }
}
