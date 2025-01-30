using System;

class DateArithmetic
{
	static void Main(string[] args)
	{
		// taking date input from the user
		Console.WriteLine("Enter date in yyyy-mm-dd or mm-dd-yyyy");
		DateTime date = DateTime.Parse(Console.ReadLine());

		Console.WriteLine("Before operation: " + date);
		
		date = date.AddDays(7);// this method return DateTime so we have to store it
		date = date.AddMonths(1);
		date = date.AddYears(2);
		
		Console.WriteLine("After operation: " + date);
	}
}