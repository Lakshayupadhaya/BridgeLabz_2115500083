using System;

class SubStringOccurance{
	public static int FindOccurance(string sentence, string subString){
	// using sliding window to solve the problem
		int occuranceCount = 0;
		int slideLength = subString.Length;
		for(int i = 0; i < sentence.Length - slideLength + 1; i++){
			string tempString = "";
			// we are adding all the charachters in the given range to the tempString
			for(int j = 0; j < slideLength; j++){
				tempString += sentence[i + j];
			}
			
			// we can also use for loop for comparing both strings
			if(string.Equals(tempString, subString)){
				// after comparing if it returns true theen increment the occurance value
				occuranceCount++;
			}
		}
		return occuranceCount;
	}
	
	public static void Main(){
		Console.Write("enter the sentence: ");
		string sentence = Console.ReadLine();
		Console.Write("enter the substring: ");
		string subString = Console.ReadLine();
		int occurance = FindOccurance(sentence, subString);
		Console.Write(occurance);
	}
}

