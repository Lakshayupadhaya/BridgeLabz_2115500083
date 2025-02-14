using System;

class SortStringWords
{
	public static void Main()
	{
		string[] arr = {"Lakshay", "Prachi", "Lakshay", "Shrey", "Pallavi"};
		
		
		
		for(int i=0; i<arr.Length; i++)
		{
			Console.WriteLine(arr[i] + " ");
			
		}
		//arr[1] = "Preksha";
		Console.WriteLine("After sorting");
		
		int n = arr.Length;
		for(int i=0; i<n-1; i++)
		{
			for(int j=0; j<n-i-1; j++)
			{
				if(arr[j][0] == arr[j+1][0])
				{
					if(arr[j].Length > arr[j+1].Length)
					{
						for(int x=1; i<arr[j+1].Length; i++)
						{
							if(arr[j][x] > arr[j+1][x])
							{
								string temp = arr[j];
								arr[j] = arr[j+1];
								arr[j+1] = temp;
							}
						}
					}
					else
					{
						for(int x=1; i<arr[j].Length; i++)
						{
							if(arr[j][x] > arr[j+1][x])
							{
								string temp = arr[j];
								arr[j] = arr[j+1];
								arr[j+1] = temp;
							}
						}
						
					}
				}
				if(arr[j][0] > arr[j+1][0])
				{
					string temp = arr[j];
					arr[j] = arr[j+1];
					arr[j+1] = temp;
				}
			}
			
		}
		for(int i=0; i<arr.Length; i++)
		{
			Console.WriteLine(arr[i] + " ");
			
		}
	}
	
}