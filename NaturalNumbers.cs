using System;

class NaturalNumbers
{
	// method to find the sum on n natural numbers
	public static int NaturalNumbersSum(int number)
	{
		// base check
		if(number <=0)
		{
			Console.WriteLine("Enter positive number");
			return -1;
		}
		int sumOfNaturalNumbers =0;
		for(int i=1; i<=number; i++)
		{
			sumOfNaturalNumbers += i;
		}
	return sumOfNaturalNumbers;
	}
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the number");
		int input = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The sum of {0} natural numbers is {1}",input, NaturalNumbersSum(input));
	}
}