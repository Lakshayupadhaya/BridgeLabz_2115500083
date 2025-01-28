using System;

class SimpleInterest
{
	public void CalculateSimpleInterest()
	{
		// takine input from the user inside method
		Console.WriteLine("Enter principal amount: ");
		double principal = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter Rate amount: ");
		double rate = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter Time amount: ");
		double time = Convert.ToDouble(Console.ReadLine());
		
		// calculate simple interest using the formula
		double simpleInterest = (principal * rate * time) / 100;
		
		Console.WriteLine( "The Simple Interest is {0} for Principal {1}, Rate of Interest {2} and Time {3}", simpleInterest, principal, rate, time);
	}
	
	static void Main()
	{
		// instance creation
		SimpleInterest run = new SimpleInterest();
		// method calling
		run.CalculateSimpleInterest();
	}

}