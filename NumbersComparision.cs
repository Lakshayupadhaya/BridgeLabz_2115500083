using System;

class NumbersComparision
{
	// method to find thhe smallest and lagrest among three
	public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
	{
		int greatest = 0;
		int smallest = 0;
		//int[] result = new int[2];
		// check if num1 is greatest
		if(number1 > number2 && number1 > number3)
		{
			greatest = number1;
			if(number2 < number3)
			{
				smallest = number2;
			}
			else
			{
				smallest = number3;
			}
			
		}
		// check if num 2 is greatest
		else if(number2 > number1 && number2 > number3)
		{
			greatest = number2;
			if(number3 < number1)
			{
				smallest = number3;
			}
			else
			{
				smallest = number1;
			}
		}
		// check if num3 is greatest
		else
		{
			greatest = number3;
			if(number2 < number1)
			{
				smallest = number2;
			}
			else
			{
				smallest = number1;
			}
		}
		//result[0] = smallest;
		//result[1] = greatest;
		//Console.WriteLine(result);
		return new int[]{smallest, greatest};
	}
	static void Main()
	{
		Console.WriteLine("Enter first number");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter second number");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter third number");
		int number3 = Convert.ToInt32(Console.ReadLine());
		
		int[] result = FindSmallestAndLargest(number1, number2, number3);
		Console.WriteLine("Smallest is {0} and the largest is {1}", result[0], result[1]);	
	}
}