using System;

class ToggleCases
{
	static void Main(string[] args)
	{
	// Input the string from the user
        Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();
		string toggledString = "";
		foreach(char ch in str)
		{
			int charAscii = (int)ch;
			if(charAscii >= 65 && charAscii <= 90)
			{
				toggledString += (char)(charAscii + 32);
			}
			else if(charAscii >= 97 && charAscii <= 122)
			{
				toggledString += (char)(charAscii - 32);
			}
			else
			{
				toggledString += ch;
			}
		}
		Console.WriteLine(toggledString);
	}
}