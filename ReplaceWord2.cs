using System;

class ReplaceWord2
{
	public static void Replace(string sentence, string replacedWord, string replacingWord)
	{
		int wordCount = 0;
		// count total words
		for(int i=0; i<sentence.Length; i++)
		{
			if(sentence[i] == ' ')
			{
				wordCount++;
			}
		}
		//declaring the array after finding the count of words
		string[] stringArr = new string[wordCount + 1];
		// checking the index of arr to know where to add in array
		int arrIndex = 0;
		//declaring a empty strinng to append word
		string word = "";
		//loop to fing the word seperated by space and add it to the array
		for(int i=0; i<sentence.Length; i++)
		{
			if(sentence[i] == ' ')
			{
				stringArr[arrIndex] = word;
				arrIndex++;
				word = "";
			}
			//checks for the last word as there is no space to perforn add operation
			else if(i == sentence.Length - 1)
			{
				word += sentence[i];
				stringArr[arrIndex] = word;
				
				
			}
			else
			{
				word += sentence[i];
			}
			
		}
		arrIndex = 0;
		// finding and matching word in string array and replacing it
		foreach(string str in stringArr)
		{
			if(str.Length == replacedWord.Length)
			{
				for(int i=0; i<replacedWord.Length; i++)
				{
					if(str[i] != replacedWord[i])
					{
						break;
					}
				}
				stringArr[arrIndex] = replacingWord;//replacing the word with the given word
				break;
			}
			arrIndex++;
		}
		// to print the array after operation
		foreach(string str in stringArr)
		{
			Console.Write(str + " ");
		}
	}
	
	static void Main(string[] args)
	{
	// input the sentence from the user
		Console.WriteLine("enter a sentence: ");
		string sentence = Console.ReadLine();
		Console.WriteLine("Enter the word to be replaced");
		string replacedWord = Console.ReadLine();
		Console.WriteLine("Enter the replacing word");
		string replacingWord = Console.ReadLine();
		sentence.Trim();
		
		
		Replace(sentence, replacedWord, replacingWord);
	}
}
