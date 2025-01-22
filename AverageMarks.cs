using System;

class AverageMarks
{
	// Declaring marks variables
	int mathMarks = 94;
	int physicsMarks = 95;
	int chemistryMarks = 96;
	// method to print the average marks
	public void ShowAverage()
	{
		int average = (mathMarks + physicsMarks + chemistryMarks) / 3;
		Console.WriteLine("Sam's average mark in PCM is " + average);
	}
}	
// child class of AverageMarks
class Program //: AverageMarks
{
	static void Main()
	{
		AverageMarks run = new AverageMarks();
		run.ShowAverage();
	}
}
	
