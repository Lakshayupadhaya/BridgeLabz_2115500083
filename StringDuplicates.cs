using System;
using System.Collections.Generic;

class StringDuplicates
{
    static void Main(string[] args)
    {
        // Input the string from the user
        Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();

        List<char> arr = new List<char>();  // Initialize empty list
        arr.Add(str[0]);  // Use Add() instead of direct index assignment
        int arrLength = 1;// index of arr to know where to add the element and the length of increasing list

        for (int i = 1; i < str.Length; i++)
        {
            bool flag = true;
            for (int j = 0; j < arrLength; j++)
            {
                if (arr[j] == str[i])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                arr.Add(str[i]); // Use Add() to dynamically grow the list
                arrLength++;
            }
        }

        str = new string(arr.ToArray()); // Convert List<char> to string
        Console.WriteLine("String after removing duplicates: " + str);
		Console.WriteLine(arr[2]);
    }
}
