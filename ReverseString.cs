using System;

class ReverseString
{
	static void Main(string[] args)
	{
		// input string from the user to reverse
		Console.WriteLine("Enter the string: ");
		string str = Console.ReadLine();
		Console.WriteLine("string before reversing: {0}",str);
		// string is immutable so crating a char array to store reverse which is mutable
		char[] charArray = str.ToCharArray();
		
		// using two pointer approach to swap the string values
		int pointer1 = 0;
		int pointer2 = str.Length-1;
		// check if the pointer 1 goes ahead or becomes equal to pointer 2
		while(!(pointer2 < 0))
		{
			// string is immutable 
			//char temp = str[pointer2];
			//str[pointer2++] = str[pointer1];
			//str[pointer1++] = temp;
			
			// storing the values in reverse order
			charArray[pointer2--] = str[pointer1++];
		}
		//converting back to string from char array
		str = new string(charArray);
		Console.WriteLine("string after reversing: {0}",str);
	}
}