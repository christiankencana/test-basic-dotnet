using System;
using System.Linq;
using System.Text;

public static class DemoString
{
    // 1. Reverse string tanpa built-in function
    public static string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        
        char[] chars = input.ToCharArray();
        int left = 0, right = chars.Length - 1;
        
        while (left < right)
        {
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;
            left++;
            right--;
        }
        
        return new string(chars);
    }

    // 2. Check palindrome
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;
        
        input = input.ToLower().Replace(" ", "");
        return input == ReverseString(input);
    }

    // 3. Count vowels
    public static int CountVowels(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;
        
        return input.ToLower().Count(c => "aiueo".Contains(c));
    }

    // 4. First non-repeating character
    public static char? FirstNonRepeatingChar(string input)
    {
        if (string.IsNullOrEmpty(input)) return null;
        
        var charCount = input.GroupBy(c => c)
                             .ToDictionary(g => g.Key, g => g.Count());
        
        return input.FirstOrDefault(c => charCount[c] == 1);
    }
}