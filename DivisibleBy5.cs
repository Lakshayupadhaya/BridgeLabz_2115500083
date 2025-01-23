using System;

class DivisibleBy5
{
	static void Main()
	{
		// input number from user
		Console.WriteLine("Enter your number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		// check if the number is divible by 5
		if(number % 5 == 0)
		{
			Console.WriteLine("Is the number {0} divisible by 5? {1}", number, (number % 5 == 0)? "Yes" : "No");
		}
		else
		{
			Console.WriteLine("Is the number {0} divisible by 5? {1}", number, (number % 5 == 0)? "Yes" : "No");
		}
	}
}