using System;
// class with method of miles conversion from kilometer
class ConvertMiles
{
	float distance = 10.8f;
	// method to calculate miles from kilometers
	// by default a non static method is private
	protected void InMiles() // it gives error if no access modifier is given -->  'ConvertMiles.InMiles()' is inaccessible due to its protection level
	{
		float milesdistance = Convert.ToSingle(distance / 1.6);
		Console.WriteLine(string.Format("The distance {0} km in miles is {1}", distance, milesdistance));
	}
}

class Program : ConvertMiles
{

	static void Main()
	{
		Program run = new Program();
		run.InMiles();
	}
}