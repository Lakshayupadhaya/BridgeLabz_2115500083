using System;

class DistributePen
{
	int pen = 19;
	int students = 3;
	// method to find pen per student and leftovers
	public void DistributeAndLeft()
	{
		int penPerStudent = pen / students;
		int leftOver = pen % students;
		
		Console.WriteLine(string.Format("The Pen Per Student is {0} and the remaining pen not distributed is {1}", penPerStudent, leftOver));
	}
}

class Program
{
	static void Main()
	{
		DistributePen run = new DistributePen();
		run.DistributeAndLeft();	
	}
}