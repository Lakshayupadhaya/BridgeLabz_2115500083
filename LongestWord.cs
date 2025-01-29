// this is a example of longestword
using System;

class LongestWord
{
	static void Main(string[] args)
	{
		// input the sentence from the user
		Console.WriteLine("Enter the sentence: ");
		string sentence = Console.ReadLine();
		
		sentence.Trim();
		
		for(int i=0; i<sentence.Length; i++)
		{
			Console.Write(sentence[i]);
			Console.WriteLine(sentence[i].GetType());
			
		}
	}
}