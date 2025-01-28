using System;

class StudentActivities
{
	// method to find maximum number of handshakes among students
	public void MaxHandShakes(int students)
	{
		// calculate maximum handshakes using formula
		int maxHandshakes = (students * (students - 1)) / 2;
		
		// result
		Console.WriteLine("Maximum handshakes among {0} students are {1}", students, maxHandshakes);
	}
	
	static void Main()
	{
		// taking input from the user(number of students)
		Console.WriteLine("Enter the number of students");
		int numberOfStudents = Convert.ToInt32(Console.ReadLine());
		
		StudentActivities run = new StudentActivities();
		
		run.MaxHandShakes(numberOfStudents);
	}
}