using System;

class TriangleRounds
{
	// goal of athlete in metres
	int athleteGoal = 5000;
	// method to find the rounds one must complete to reach goal 
	public void FindRounds(double side1, double side2, double side3)
	{
		// sum of sides (parameter)
		double parameter = side1 + side2 + side3;
		// No of rounds = total diatance / parameter
		double roundsToComplete = athleteGoal / parameter;
		// result
		Console.WriteLine("the number of rounds user needs to do to complete 5km run are {0}", roundsToComplete);
	}
	
	static void Main()
	{
		// take input sides of the triangle from the user
		Console.Write("Enter first side of triangle: ");
		double side1 = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter first side of triangle: ");
		double side2 = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter first side of triangle: ");
		double side3 = Convert.ToDouble(Console.ReadLine());
		
		TriangleRounds run = new TriangleRounds();
		run.FindRounds(side1, side2, side3);
		
	}
}