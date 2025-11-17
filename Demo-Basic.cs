using System;

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

public static class DemoBasic
{
    public static void Run()
    {
        Console.WriteLine("Ini file 2");

        var p = new Person
        {
            Name = "Andi",
            Age = 25
        };

        Console.WriteLine($"{p.Name}, umur {p.Age}");
    }
}
