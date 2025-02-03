using System;
using System.Collections;

class SwapFirstChar2
{
	
	static void Main()
	{
		string str = "hi i am lakshay upadhaya";
		ArrayList arrayIndexes = new ArrayList();//creating a array list to store the indexes of the  letters to be replaced
		arrayIndexes.Add(0);
		for(int i=0; i<str.Length; i++)
		{
			if(str[i] == ' ')
			{
				arrayIndexes.Add(i + 1);//storing the indexes
			}
		}
		char[] charArray = str.ToCharArray();
		for(int i=0; i<arrayIndexes.Count / 2; i++)//instead of length array list has count method
		{
			//replacing the letters in a char array
			char temp = charArray[(int)arrayIndexes[i]];
			charArray[(int)arrayIndexes[i]] = charArray[(int)arrayIndexes[(int)arrayIndexes.Count - 1 - i]];
			charArray[(int)arrayIndexes[(int)arrayIndexes.Count - 1 - i]] = temp;
		}
		string result = new string(charArray);//converting back to string
		Console.WriteLine(result);
	}
}