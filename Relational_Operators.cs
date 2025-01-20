using System;

class Relational_Operators
{
	
	static void Main()
	{
		int a = 10;
		int b = 20;
		Console.Write(string.Format("Value of a and b are {0} and b {1} respectively", a, b));
		
		Console.WriteLine("a equal to b: " + (a == b));
		Console.WriteLine("a less than b: "+ (a < b));
		Console.WriteLine("a greater than b: " + (a > b));
		Console.WriteLine("a less than or equal to b: " + (a <= b));
		Console.WriteLine("a greater than or equal to b: " + (a >= b));
		Console.WriteLine("a not equal to b: " + (a != b));
	}

}
