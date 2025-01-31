using System;

class Palindrome
{
	public static void CheckPalindrome(string str)
	{
		char[] charArr = str.ToCharArray();
		
		Array.Reverse(charArr);
		bool flag = true;
		for(int i=0; i<str.Length; i++)
		{
			if(charArr[i] != str[i])
			{
				Console.WriteLine("String {0} is not palindrome", str);
				flag = false;
				break;
			}
		}
		if(flag)
		{
			Console.WriteLine("String {0} is palindrome", str);
		}	
	}
	
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the string");
		string str = Console.ReadLine();
		CheckPalindrome(str);
	}
}