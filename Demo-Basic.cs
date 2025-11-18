using System;
using System.Linq;

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Person(string name = "", int age = 0)
    {
        Name = name;
        Age = age;
    }
}

public static class DemoBasic
{
    public static void Run()
    {
        //  Example using the Person class
        // var p = new Person
        // {
        //     Name = "Andi",
        //     Age = 25
        // };
        // Console.WriteLine($"{p.Name}, umur {p.Age}");

        // Console.WriteLine("=== DEMO BASIC PROGRAMMING ===\n");
        DemoVariablesAndDataTypes();
        // DemoArithmetic();
        // DemoLogical();
        // DemoComparison();
        // DemoConditional();
        // DemoLoops();
        // DemoArrays();
        // DemoFunctions();
        // DemoOOP();
    }

    // 1. Variables & Data Types
    private static void DemoVariablesAndDataTypes()
    {
        Console.WriteLine("1. VARIABLES & DATA TYPES");
        Console.WriteLine(new string('-', 40));

        // Integer
        int age = 25;
        Console.WriteLine($"Integer: age = {age}");

        // Double/Float
        double price = 19.99;
        Console.WriteLine($"Double: price = {price}");

        // String
        string name = "John Doe";
        Console.WriteLine($"String: name = {name}");

        // Boolean
        bool isActive = true;
        Console.WriteLine($"Boolean: isActive = {isActive}");

        // Null
        string? nothing = null;
        Console.WriteLine($"Null: nothing = {nothing ?? "null"}");

        Console.WriteLine();
    }

    // 2. Arithmetic Operations
    private static void DemoArithmetic()
    {
        Console.WriteLine("2. ARITHMETIC OPERATIONS");
        Console.WriteLine(new string('-', 40));

        int a = 10;
        int b = 3;

        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"Addition (a + b): {a + b}");
        Console.WriteLine($"Subtraction (a - b): {a - b}");
        Console.WriteLine($"Multiplication (a * b): {a * b}");
        Console.WriteLine($"Division (a / b): {a / b}");
        Console.WriteLine($"Modulus (a % b): {a % b}");
        Console.WriteLine($"Exponentiation (Math.Pow(a, b)): {Math.Pow(a, b)}");

        // Increment & Decrement
        int c = 5;
        Console.WriteLine($"Original c = {c}");
        Console.WriteLine($"Pre-increment (++c): {++c}");
        Console.WriteLine($"Post-increment (c++): {c++}");
        Console.WriteLine($"After post-increment c = {c}");

        Console.WriteLine();
    }

    // 3. Logical Operations
    private static void DemoLogical()
    {
        Console.WriteLine("3. LOGICAL OPERATIONS");
        Console.WriteLine(new string('-', 40));

        bool x = true;
        bool y = false;

        Console.WriteLine($"x = {x}, y = {y}");
        Console.WriteLine($"AND (x && y): {x && y}");
        Console.WriteLine($"OR (x || y): {x || y}");
        Console.WriteLine($"NOT (!x): {!x}");
        Console.WriteLine($"XOR (x ^ y): {x ^ y}");

        Console.WriteLine();
    }

    // 4. Comparison Operations
    private static void DemoComparison()
    {
        Console.WriteLine("4. COMPARISON OPERATIONS");
        Console.WriteLine(new string('-', 40));

        int a = 10;
        int b = 5;
        string c = "10";

        Console.WriteLine($"a = {a}, b = {b}, c = '{c}'");
        Console.WriteLine($"Equal (a == int.Parse(c)): {a == int.Parse(c)}");
        Console.WriteLine($"Not equal (a != b): {a != b}");
        Console.WriteLine($"Greater than (a > b): {a > b}");
        Console.WriteLine($"Less than (a < b): {a < b}");
        Console.WriteLine($"Greater or equal (a >= b): {a >= b}");
        Console.WriteLine($"Less or equal (a <= b): {a <= b}");

        Console.WriteLine();
    }

    // 5. Conditional Statements
    private static void DemoConditional()
    {
        Console.WriteLine("5. CONDITIONAL STATEMENTS");
        Console.WriteLine(new string('-', 40));

        // If-Else
        int score = 85;
        Console.WriteLine($"Score: {score}");

        if (score >= 90)
        {
            Console.WriteLine("Grade: A (Excellent)");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade: B (Good)");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade: C (Average)");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Grade: D (Below Average)");
        }
        else
        {
            Console.WriteLine("Grade: F (Fail)");
        }

        // Switch-Case
        int day = 3;
        Console.WriteLine($"Day number: {day}");
        Console.Write("Day name: ");

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        // Ternary Operator
        int age = 20;
        string status = (age >= 18) ? "Adult" : "Minor";
        Console.WriteLine($"Age: {age}, Status: {status}");

        Console.WriteLine();
    }

    // 6. Loop Statements
    private static void DemoLoops()
    {
        Console.WriteLine("6. LOOP STATEMENTS");
        Console.WriteLine(new string('-', 40));

        // For Loop
        Console.Write("For loop (1 to 5): ");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        // While Loop
        Console.Write("While loop (1 to 5): ");
        int j = 1;
        while (j <= 5)
        {
            Console.Write($"{j} ");
            j++;
        }
        Console.WriteLine();

        // Do-While Loop
        Console.Write("Do-While loop (1 to 5): ");
        int k = 1;
        do
        {
            Console.Write($"{k} ");
            k++;
        } while (k <= 5);
        Console.WriteLine();

        // Foreach Loop
        Console.Write("Foreach loop: ");
        string[] colors = { "Red", "Green", "Blue" };
        foreach (var color in colors)
        {
            Console.Write($"{color} ");
        }
        Console.WriteLine();

        // Break and Continue
        Console.Write("Loop with break at 3: ");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3) break;
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        Console.Write("Loop with continue at 3: ");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3) continue;
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        // Nested Loop
        Console.WriteLine("Nested loop (multiplication table 2x2):");
        for (int i = 1; i <= 2; i++)
        {
            for (int jj = 1; jj <= 2; jj++)
            {
                Console.Write($"{i} x {jj} = {i * jj}  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    // 7. Arrays
    private static void DemoArrays()
    {
        Console.WriteLine("7. ARRAYS");
        Console.WriteLine(new string('-', 40));

        // Array
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Array: {string.Join(", ", numbers)}");
        Console.WriteLine($"First element: {numbers[0]}");
        Console.WriteLine($"Array length: {numbers.Length}");

        // Multi-dimensional Array
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine("Multi-dimensional array:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("  ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }

        // List (Dynamic Array)
        var fruits = new System.Collections.Generic.List<string> { "Apple", "Banana", "Orange" };
        Console.WriteLine($"Original fruits: {string.Join(", ", fruits)}");

        fruits.Add("Mango");
        Console.WriteLine($"After add: {string.Join(", ", fruits)}");

        fruits.RemoveAt(fruits.Count - 1);
        Console.WriteLine($"After remove last: {string.Join(", ", fruits)}");

        Console.WriteLine();
    }

    // 8. Functions
    private static void DemoFunctions()
    {
        Console.WriteLine("8. FUNCTIONS");
        Console.WriteLine(new string('-', 40));

        // Simple Function
        int sum = Add(5, 3);
        Console.WriteLine($"Add(5, 3) = {sum}");

        // Function with Default Parameters
        string greeting1 = Greet("Alice");
        string greeting2 = Greet("Bob", "Good evening");
        Console.WriteLine(greeting1);
        Console.WriteLine(greeting2);

        // Function with Return Type
        bool isEven = IsEven(4);
        Console.WriteLine($"IsEven(4): {isEven}");

        // Function with Variable Arguments
        int total = Sum(1, 2, 3, 4, 5);
        Console.WriteLine($"Sum(1, 2, 3, 4, 5) = {total}");

        // Recursive Function
        int factorial = Factorial(5);
        Console.WriteLine($"Factorial(5) = {factorial}");

        Console.WriteLine();
    }

    // Helper Functions
    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static string Greet(string name, string message = "Hello")
    {
        return $"{message}, {name}!";
    }

    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    private static int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }

    private static int Factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    // 9. Object-Oriented Programming
    private static void DemoOOP()
    {
        Console.WriteLine("9. OBJECT-ORIENTED PROGRAMMING");
        Console.WriteLine(new string('-', 40));

        // Creating Objects
        var person1 = new Person("Alice", 25);
        var person2 = new Person("Bob", 30);

        Console.WriteLine($"Person 1: {person1.Name}, age {person1.Age}");
        Console.WriteLine($"Person 2: {person2.Name}, age {person2.Age}");

        Console.WriteLine();
    }
}
