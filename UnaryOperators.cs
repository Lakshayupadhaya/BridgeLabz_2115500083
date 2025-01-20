using System;

class UnaryOperators 
{
	static void Main(string[] args) 
	{
		int a = 5;

		Console.WriteLine("a: " + a); 
		Console.WriteLine("Pre increment a : " + ++a);  
		Console.WriteLine("Post increment a: " + a++);  
		Console.WriteLine("a: " + a); // 7
		Console.WriteLine("Pre decrement a: " + --a); 
		Console.WriteLine("Post decrement a: " + a--);  
		Console.WriteLine("a: " + a); 
	}		
}