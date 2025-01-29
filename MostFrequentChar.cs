using System;

class MostFrequentChar
{
	static void Main(string[] args)
	{
		int[] charArr = new int[26];
		int maxm = charArr[0];
		int maxIndex = 0;
		
		// input  string from user
		Console.WriteLine("Enter the string in lowercase: ");
        string str = Console.ReadLine();
		
		// storing count of each character in a array
		foreach(char ch in str)
		{
			charArr[ch - 97] += 1;
		}
		
		// finding the character whose frequency is maximum
		for(int i=0; i<26; i++)
		{
			if(charArr[i] > maxm)
			{
				maxm = charArr[i];
				maxIndex = i;
			}
		}
		Console.WriteLine("Most Frequent Character: {0}", (char)(maxIndex+97));
	}
}