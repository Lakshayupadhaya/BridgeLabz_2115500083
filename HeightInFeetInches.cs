using System;

class HeightInFeetInches
{
    static void Main()
    {
        // taking input height in cm
        Console.Write("Enter your height in centimeters: ");
        double heightInCm;

        // Validate user input
        if (double.TryParse(Console.ReadLine(), out heightInCm))
        {
            // Conversion factors
            double inches = heightInCm / 2.54; // Convert cm to inches
            int feet = (int)(inches / 12);     // Convert inches to feet (integer part)
            inches = inches % 12;             // Remaining inches

            Console.WriteLine(string.Format("Your height in cm is {0:F2}.", heightInCm));
            Console.WriteLine(string.Format("Your height in feet and inches is {0} feet and {1:F2} inches.", feet, inches));
        }
		// if the user inputs invalid data
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}

