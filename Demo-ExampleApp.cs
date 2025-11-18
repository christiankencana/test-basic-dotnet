using System;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}

public static class DemoExampleApp
{
    private static List<User> users = new List<User>
    {
        new User("admin", "123456"),
        new User("john", "password"),
        new User("jane", "qwerty")
    };
    
    private static User currentUser = null;
    
    public static void Run()
    {
        StartApp();
    }
    
    private static void StartApp()
    {
        if (currentUser == null)
        {
            Login();
        }
        else
        {
            ShowMenu();
        }
    }
    
    private static void Login()
    {
        Console.Clear();
        Console.WriteLine("=== LOGIN ===");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        
        Console.Write("Password: ");
        string password = Console.ReadLine();
        
        // Find user
        foreach (var user in users)
        {
            if (user.Username == username && user.Password == password)
            {
                currentUser = user;
                Console.WriteLine($"Welcome, {username}!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                ShowMenu();
                return;
            }
        }
        
        Console.WriteLine("Invalid username or password!");
        Console.WriteLine("Press any key to try again...");
        Console.ReadKey();
        Login(); // Recursively call login again
    }
    
    private static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine($"=== MAIN MENU - Hello {currentUser.Username} ===");
        Console.WriteLine("1. View Profile");
        Console.WriteLine("2. Change Password");
        Console.WriteLine("3. View Users List");
        Console.WriteLine("4. About System");
        Console.WriteLine("0. Logout");
        Console.Write("Select option: ");
        
        string choice = Console.ReadLine();
        ProcessMenu(choice);
    }
    
    private static void ProcessMenu(string choice)
    {
        Console.Clear();
        
        switch (choice)
        {
            case "1":
                ViewProfile();
                break;
            case "2":
                ChangePassword();
                break;
            case "3":
                ViewUsersList();
                break;
            case "4":
                AboutSystem();
                break;
            case "0":
                Logout();
                return;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
        
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        ShowMenu(); // Return to menu
    }
    
    private static void ViewProfile()
    {
        Console.WriteLine("=== USER PROFILE ===");
        Console.WriteLine($"Username: {currentUser.Username}");
        Console.WriteLine($"Status: Active");
        Console.WriteLine($"Login Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
    }
    
    private static void ChangePassword()
    {
        Console.WriteLine("=== CHANGE PASSWORD ===");
        Console.Write("Current Password: ");
        string oldPassword = Console.ReadLine();
        
        if (oldPassword == currentUser.Password)
        {
            Console.Write("New Password: ");
            string newPassword = Console.ReadLine();
            currentUser.Password = newPassword;
            Console.WriteLine("Password changed successfully!");
        }
        else
        {
            Console.WriteLine("Wrong current password!");
        }
    }
    
    private static void ViewUsersList()
    {
        Console.WriteLine("=== USERS LIST ===");
        Console.WriteLine($"Total Users: {users.Count}");
        Console.WriteLine();
        
        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {users[i].Username}");
        }
    }
    
    private static void AboutSystem()
    {
        Console.WriteLine("=== ABOUT SYSTEM ===");
        Console.WriteLine("Simple Login System v1.0");
        Console.WriteLine("Created for Interview Demo");
        Console.WriteLine($"Current Date: {DateTime.Now:yyyy-MM-dd}");
        Console.WriteLine("Language: C#");
    }
    
    private static void Logout()
    {
        currentUser = null;
        Console.WriteLine("Logged out successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        StartApp(); // Restart the app
    }
}