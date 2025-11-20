using System;

public class Program
{
    public static void Main()
    {
        // Demo 1: Basic
        // DemoBasic.Run();
        // System.Console.WriteLine();

        // Demo 2: Pattern
        // DemoPattern.PrintAscending(3);
        // System.Console.WriteLine();
        // DemoPattern.PrintDescending(3);
        // System.Console.WriteLine();

        // Demo 3: String
        // System.Console.WriteLine($"Word - Reverse: {DemoString.ReverseString("hello")}");
        // System.Console.WriteLine($"Word - Palindrome: {DemoString.IsPalindrome("madam")}");
        // System.Console.WriteLine($"Word - Vowels: {DemoString.CountVowels("programming")}");
        // System.Console.WriteLine();

        // Demo 4: Array
        // int[] nums = { 2, 7, 11, 15 };
        // var result = DemoArray.TwoSum(nums, 9);
        // System.Console.WriteLine($"Two Sum indices: [{result?[0]}, {result?[1]}]");
        // System.Console.WriteLine();
        // int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        // System.Console.WriteLine($"Max subarray sum: {DemoArray.MaxSubarraySum(arr)}");
        // System.Console.WriteLine();

        // Demo 5: Sorting
        int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
        DemoSorting.BubbleSortAsc((int[])arr1.Clone());
        DemoSorting.BubbleSortDesc((int[])arr1.Clone());
        
        int[] arr2 = { 64, 34, 25, 12, 22, 11, 90 };
        DemoSorting.QuickSortAsc((int[])arr2.Clone(), 0, arr2.Length - 1);
        DemoSorting.QuickSortDesc((int[])arr2.Clone(), 0, arr2.Length - 1);
        
        int[] arr3 = { 64, 34, 25, 12, 22, 11, 90 };
        DemoSorting.MergeSortAsc((int[])arr3.Clone(), 0, arr3.Length - 1);
        DemoSorting.MergeSortDesc((int[])arr3.Clone(), 0, arr3.Length - 1);
        
        int[] arr4 = { 64, 34, 25, 12, 22, 11, 90 };
        DemoSorting.InsertionSortAsc((int[])arr4.Clone());
        DemoSorting.InsertionSortDesc((int[])arr4.Clone());
        
        int[] arr5 = { 64, 34, 25, 12, 22, 11, 90 };
        DemoSorting.SelectionSortAsc((int[])arr5.Clone());
        DemoSorting.SelectionSortDesc((int[])arr5.Clone());
        
        System.Console.WriteLine();

        // Demo 6: OOP
        // DemoOOP.Run();
        // System.Console.WriteLine();

        // Demo 7: Menu Login
        // DemoExampleApp.Run();
    }
}
