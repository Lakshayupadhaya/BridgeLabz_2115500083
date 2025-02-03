// hi i am lakshay upadhaya

using System;

class SwapFirstchar
{
	static void Main(string[] args)
	{
		string str = "hi i am lakshay upadhaya";
		int countSpaces = 0;
		for(int i=0; i<str.Length; i++)
		{
			if(str[i] == ' ')
			{
				countSpaces++;
			}
		}
		
		string[] stringArr = new string[countSpaces + 1];
		int arrIndex = 0;
		string word = "";
		for(int i=0; i<str.Length; i++)
		{
			if(str[i] == ' ')
			{
				stringArr[arrIndex] = word;
				arrIndex++;
				word = "";
				//continue;
			}
			else if(i == str.Length-1)
			{
				stringArr[arrIndex] = word;
				arrIndex++;
				word = "";
			}
			else
			{	
				word += str[i];
			}
		}	
		
		for(int j=0; j<(stringArr.Length) / 2; j++)
		{
			char[] chrArr =  stringArr[j].ToCharArray();
			char[] chrArr2 =  stringArr[stringArr.Length - 1 - j].ToCharArray();
			char c1 = chrArr[0];//h
			char c2 = chrArr2[0];//u
			chrArr[0] = c2;
			chrArr2[0] = c1;
			Console.WriteLine(chrArr);
			Console.WriteLine(chrArr2);
			stringArr[j] = chrArr.ToString();
			stringArr[stringArr.Length - 1 - j] = chrArr2.ToString();
			Console.WriteLine(stringArr[j].ToString());
			Console.WriteLine(stringArr[stringArr.Length - 1 - j].ToString());
		}
		
		foreach(string strarr in stringArr)
		{
			Console.Write(strarr + " ");
		}
	}
}
// hi i  |  am  |  lakshay upadhaya