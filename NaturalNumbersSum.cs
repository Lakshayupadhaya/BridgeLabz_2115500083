using System;

class NaturalNumbersSum
{
	// recursive method to calculate the sum of n natural numbers
	public static int RecursiveSum(int number)
	{
		if(number == 1)
		{
			return 1;
		}
		return number + RecursiveSum(number-1);
	}
	//method using formula to calculate the sum of n natural numbers
	public static int FormulaSum(int number)
	{
		return number * (number + 1) / 2;
	}
	
	static void Main()
	{
		Console.WriteLine("Enter the value of number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("recuersively {0} and using formula {1}", RecursiveSum(number), FormulaSum(number));
	}
}