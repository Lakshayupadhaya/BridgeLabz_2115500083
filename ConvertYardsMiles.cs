using System;

class ConvertYardsMiles
{
    static void Main()
    {
        // input distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        double distanceInYards = distanceInFeet / 3; // 1 yard = 3 feet
        double distanceInMiles = distanceInYards / 1760; // 1 mile = 1760 yards

        // output
        Console.WriteLine("The distance in yards is {0:F2} yards.", distanceInYards);
        Console.WriteLine("The distance in miles is {0:F2} miles.", distanceInMiles);
	}
}	
