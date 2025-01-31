//0 1 1 2 3 5 8 13
using System; 

class Fibonacci
{
	public static void PrintFibonacciSeries(int num)
	{
		int num1 = 0;
		int num2 = 1;
		if(num == 1)
		{
			Console.Write(num1 + " ");
		}
		else if(num == 2)
		{
			Console.Write(num1 + " " + num2);
		}
		else
		{
			Console.Write(num1 + " " + num2 + " ");
			for(int i = 3; i<=num; i++)
			{
				Console.Write((num1 + num2) + " ");
				int temp = num1;
				num1 = num2;
				num2 = temp + num2;
			}
		}
	}
	
	static void Main(string[] args)
	{
		//taking input from the user
		Console.WriteLine("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		PrintFibonacciSeries(number);
	}
}