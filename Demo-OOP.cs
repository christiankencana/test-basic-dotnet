using System;
using System.Collections.Generic;

// 1. Inheritance & Polymorphism
public abstract class Animal
{
    public string Name { get; set; }
    
    public Animal(string name) => Name = name;
    
    public virtual void Eat() => Console.WriteLine($"{Name} is eating");
    
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    
    public override void MakeSound() => Console.WriteLine($"{Name} says: Woof!");
    
    public void Fetch() => Console.WriteLine($"{Name} is fetching the ball");
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    
    public override void MakeSound() => Console.WriteLine($"{Name} says: Meow!");
    
    public void Climb() => Console.WriteLine($"{Name} is climbing the tree");
}

// 2. Encapsulation
public class BankAccount
{
    private decimal balance;
    private string accountNumber;
    
    public BankAccount(string accountNumber, decimal initialBalance = 0)
    {
        this.accountNumber = accountNumber;
        balance = initialBalance >= 0 ? initialBalance : 0;
    }
    
    public decimal Balance => balance; // Read-only property
    public string AccountNumber => accountNumber;
    
    public bool Deposit(decimal amount)
    {
        if (amount <= 0) return false;
        balance += amount;
        Console.WriteLine($"Deposited: ${amount}. New balance: ${balance}");
        return true;
    }
    
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > balance) return false;
        balance -= amount;
        Console.WriteLine($"Withdrawn: ${amount}. New balance: ${balance}");
        return true;
    }
}

// 3. Interface & Composition
public interface IVehicle
{
    void Start();
    void Stop();
}

public class Engine
{
    public string Type { get; set; }
    public bool IsRunning { get; private set; }
    
    public Engine(string type) => Type = type;
    
    public void StartEngine()
    {
        IsRunning = true;
        Console.WriteLine($"{Type} engine started");
    }
    
    public void StopEngine()
    {
        IsRunning = false;
        Console.WriteLine($"{Type} engine stopped");
    }
}

public class Car : IVehicle
{
    public string Brand { get; set; }
    private Engine engine;
    
    public Car(string brand, string engineType)
    {
        Brand = brand;
        engine = new Engine(engineType);
    }
    
    public void Start()
    {
        Console.WriteLine($"Starting {Brand} car...");
        engine.StartEngine();
    }
    
    public void Stop()
    {
        Console.WriteLine($"Stopping {Brand} car...");
        engine.StopEngine();
    }
}

public static class DemoOOP
{
    public static void Run()
    {
        Console.WriteLine("=== DEMO OOP CONCEPTS ===\n");

        // 1. Inheritance & Polymorphism
        Console.WriteLine("1. Inheritance & Polymorphism:");
        List<Animal> animals = new List<Animal>
        {
            new Dog("Buddy"),
            new Cat("Whiskers")
        };
        
        foreach (Animal animal in animals)
        {
            animal.Eat();
            animal.MakeSound();
        }
        
        // Specific behavior
        if (animals[0] is Dog dog) dog.Fetch();
        if (animals[1] is Cat cat) cat.Climb();
        Console.WriteLine();

        // 2. Encapsulation
        Console.WriteLine("2. Encapsulation:");
        var account = new BankAccount("ACC001", 100);
        Console.WriteLine($"Account: {account.AccountNumber}, Initial Balance: ${account.Balance}");
        account.Deposit(50);
        account.Withdraw(30);
        account.Withdraw(200); // Should fail
        Console.WriteLine();

        // 3. Interface & Composition
        Console.WriteLine("3. Interface & Composition:");
        IVehicle car = new Car("Toyota", "V6");
        car.Start();
        car.Stop();
    }
}