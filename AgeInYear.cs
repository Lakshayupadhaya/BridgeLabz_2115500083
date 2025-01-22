using System;

class FindAge
{
	// Born year variable declaration
	int  yearBorn;
	
	public  void AgeInYear(int year)
	{
		if(this.yearBorn > year)
		{
			Console.WriteLine("This person was born before this year ");
		}
		else
		{
			int finalYear = year - this.yearBorn;
			Console.WriteLine(string.Format("Harry's age in {0} is {1}", year, finalYear));
		}
	}
	
	static void Main()
	{
		FindAge harry = new FindAge();
		harry.yearBorn = 2000;
		harry.AgeInYear(2024);
	}
}