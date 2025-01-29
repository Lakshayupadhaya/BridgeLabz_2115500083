using System;

class CheckTwoAnagram
{
	static void Main(string[] args)
	{
		// input two string from user
		Console.WriteLine("Enter the first string: ");
        string string1 = Console.ReadLine();
		
		Console.WriteLine("Enter the second string: ");
        string string2 = Console.ReadLine();
		
		int[] string1Arr = new int[26];
		int[] string2Arr = new int[26];
		//stores the count of characters
		foreach(char ch in string1)
		{
			string1Arr[ch - 97] += 1;
		}
		// stores of the count of character in string 2
		foreach(char ch in string2)
		{
			string2Arr[ch - 97] += 1;
		}
		bool flag = true;
		for(int i=0; i<26; i++)
		{
			if(string1Arr[i] == string2Arr[i])
			{
				continue;
			}
			
			else
			{
				flag = false;
				Console.WriteLine("Strings are not anagram");
			}
		}
		if(flag)
		{
			Console.WriteLine("Strings are anagram");
		}
	}
}