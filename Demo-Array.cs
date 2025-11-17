using System;
using System.Collections.Generic;
using System.Linq;

public static class DemoArray
{
    // 1. Find duplicate numbers
    public static List<int> FindDuplicates(int[] arr)
    {
        return arr.GroupBy(x => x)
                  .Where(g => g.Count() > 1)
                  .Select(g => g.Key)
                  .ToList();
    }

    // 2. Two Sum Problem
    public static int[]? TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dict.ContainsKey(complement))
            {
                return new int[] { dict[complement], i };
            }
            dict[nums[i]] = i;
        }
        
        return null;
    }

    // 3. Find missing number (1 to n)
    public static int FindMissingNumber(int[] arr, int n)
    {
        int expectedSum = n * (n + 1) / 2;
        int actualSum = arr.Sum();
        return expectedSum - actualSum;
    }

    // 4. Rotate array
    public static void RotateArray(int[] arr, int k)
    {
        k = k % arr.Length;
        Reverse(arr, 0, arr.Length - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, arr.Length - 1);
    }

    private static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    // 5. Maximum subarray sum (Kadane's Algorithm)
    public static int MaxSubarraySum(int[] arr)
    {
        int maxSoFar = arr[0];
        int maxEndingHere = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}