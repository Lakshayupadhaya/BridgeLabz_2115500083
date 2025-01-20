using System;

class TernaryOperator
{
	static void Main()
	{
		int a = 1000;
		
		int b = 999;
		
		int max = (a < b)?b:a;
		Console.WriteLine("Max is: " + max);
	}
}