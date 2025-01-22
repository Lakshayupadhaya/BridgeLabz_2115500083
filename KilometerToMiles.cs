using System;

class KilometerToMiles
{
	public void MilesFromKilometer()
	{
		Console.Write("Enter distance in Kilometer: ");
		double km = Convert.ToDouble(Console.ReadLine());
		
		double miles = Convert.ToDouble(km * 0.621371);
		
		Console.WriteLine(string.Format("The total miles is {0} mile for the given {1} km", miles, km));
	}

}

class Program
{
	static void Main()
	{
		KilometerToMiles run = new KilometerToMiles();
		run.MilesFromKilometer();
	}
}