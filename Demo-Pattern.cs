using System;

public static class DemoPattern
{
    // Pola naik:
    // +
    // ++
    // +++
    public static void PrintAscending(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('+', i));
        }
    }

    // Pola turun:
    // +++
    // ++
    // +
    public static void PrintDescending(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(new string('+', i));
        }
    }
}