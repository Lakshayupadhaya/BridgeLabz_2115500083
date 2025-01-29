using System;

class RemoveSpecified
{
	static void Main(string[] args)
	{
		// input  string from user and specified character
		Console.Write("String: ");
		string str = Console.ReadLine();
		
		Console.Write("Character to Remove: ");
		char character = Convert.ToChar(Console.ReadLine());
		
		string removedCharString = "";
		
		foreach(char ch in str)
		{
			if(ch != character)
			{
				removedCharString += ch;
			}
		}
		Console.WriteLine("Modified String: " + removedCharString);
	}
}