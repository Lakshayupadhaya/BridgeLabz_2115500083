using System;

public class CalendarProgram
{
    // Array of month names
    static string[] monthNames = { "January", "February", "March", "April", "May", "June", 
                                    "July", "August", "September", "October", "November", "December" };

    // Array of days in each month for common years
    static int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get the number of days in a month
    public static int GetDaysInMonth(int month, int year)
    {
        if (month == 2 && IsLeapYear(year)) // Handle February in a leap year
        {
            return 29;
        }
        return daysInMonth[month - 1]; // Return the number of days in the month
    }

    // Method to get the first day of the month (using the Gregorian calendar algorithm)
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int y = year;
        int m = month;

        if (m < 3)
        {
            m += 12;
            y -= 1;
        }

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;

        return d0; // Day of the week (0 = Sunday, 6 = Saturday)
    }

    // Method to display the calendar for a given month and year
    public static void DisplayCalendar(int month, int year)
    {
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        // Display the header (month name and year)
        Console.WriteLine("{0} {1}", monthNames[month - 1], year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Display the first line of indentation (for the starting day)
        int day = 1;
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    "); // Space for the empty days before the start of the month
        }

        // Display the days of the month
        for (int i = firstDay; i < 7; i++)
        {
            Console.Write("{0,3} ", day);
            day++;
        }

        Console.WriteLine();

        // Display the remaining lines of the calendar
        while (day <= daysInMonth)
        {
            for (int i = 0; i < 7 && day <= daysInMonth; i++)
            {
                Console.Write("{0,3} ", day);
                day++;
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        // Get the month and year from the user
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        // Display the calendar
        DisplayCalendar(month, year);
    }
}
