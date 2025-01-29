using System;

class Palindrone
{
	static void Main(string[] args)
	{
		//taking string input from the user
		Console.WriteLine("Enter the string: ");
		string str = Console.ReadLine();
		
		// creating two pointer for the traversing
		int pointer1 = 0;
		int pointer2 = str.Length-1;
		// check pointer 1 is always less than or equal to pointer2
		while(pointer1 <= pointer2)
		{
			if(pointer1 == pointer2)
			{
				Console.WriteLine("String is palindrone");
				break;
			}
			else if(str[pointer1++] != str[pointer2--])
			{
				Console.WriteLine("String is not palindrone");
				break;
			}
		}
	
	}
}
