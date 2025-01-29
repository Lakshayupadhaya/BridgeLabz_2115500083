using System;

class VowelsAndConsonants
{
	static void Main(string[] args)
	{
		// declaring count of vowels and consonants to zero
		int vowelCount = 0;
		int consonantCount = 0;
		
		Console.WriteLine("Enter the string: ");
		string str = Console.ReadLine();
		//covnverting it to lower case
		str.ToLower();
		
		for(int i=0; i<str.Length; i++)
		{
			// counts vowels
			if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
			{
				vowelCount++;
			}
			// counts consonants
			else
			{
				consonantCount++;
			}
		}
		Console.WriteLine("String {0} contains {1} vowels and {2} consonants.", str, vowelCount, consonantCount);
	}
}