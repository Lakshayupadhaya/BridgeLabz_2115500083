using System;

	class LogicalOperators 
	{
		static void Main(string[] args) 
		{
			bool x = true;
			bool y = false;

			Console.WriteLine("x and y: " + (x && y)); // false
			Console.WriteLine("x or y: " + (x || y)); // true
			Console.WriteLine("Not-x: " + (!x)); // false
			Console.WriteLine("Not-y: " + (!y)); // true
		}
	}