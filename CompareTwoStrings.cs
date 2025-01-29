// lakshay  lakshaya

using System;

class CompareTwoStrings
{
	static void Main(string[] args)
	{
		// input two string from user
		Console.WriteLine("Enter the first string: ");
        string string1 = Console.ReadLine();
		
		Console.WriteLine("Enter the second string: ");
        string string2 = Console.ReadLine();
		
		// to find the string which is smallest in chharacters
		string smallestString = string1.Length < string2.Length ? string1 : string2;
		// flag for the very last case where a string is substring of another making it similar to its length of the other string
		bool flag = true;
		for(int i=0; i<smallestString.Length; i++)
		{
			
			if(string1[i] == string2[i])
			{
				continue;
			}
			//checks if string 1 comes before
			else if(string1[i] < string2[i])
			{
				Console.WriteLine("{0} comes before {1} in lexicographical order", string1, string2);
				flag = false;
				break;
			}
			//checks if string 2 comes before
			else if(string2[i] < string1[i])
			{
				Console.WriteLine("{0} comes before {1} in lexicographical order", string2, string1);
				flag = false;
				break;
			}
		}
		// handling the same case mentioned above flag declaration
		if(flag)
		{
			Console.WriteLine("{0} comes before {1} in lexicographical order", smallestString, smallestString.Length == string1.Length?string2:string1);
		}
	}
}