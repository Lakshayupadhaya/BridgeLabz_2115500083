﻿using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return new int[0];

        int n = nums.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> deque = new LinkedList<int>(); // Stores indices

        for (int i = 0; i < n; i++)
        {
            // Remove elements out of the window
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
                deque.RemoveFirst();

            // Remove elements smaller than current element
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                deque.RemoveLast();

            // Add current index
            deque.AddLast(i);

            // Store the maximum for this window (starting from i >= k-1)
            if (i >= k - 1)
                result[i - k + 1] = nums[deque.First.Value];
        }

        return result;
    }

    public static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] maxValues = MaxSlidingWindow(nums, k);

        Console.WriteLine("Input Array: " + string.Join(", ", nums));
        Console.WriteLine("Sliding Window Maximums: " + string.Join(", ", maxValues));
    }
}

