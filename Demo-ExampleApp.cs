using System;
using System.Collections.Generic;

public class User
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
}

public static class DemoExampleApp
{
    private static List<User> users = new List<User>
    {
        new User { Username = "admin", Password = "admin123", Role = "Admin" },
        new User { Username = "user", Password = "user123", Role = "User" }
    };

    private static User? currentUser = null;

    public static void Run()
    {
        while (true)
        {
            if (currentUser == null)
            {
                ShowLoginMenu();
            }
            else
            {
                ShowMainMenu();
            }
        }
    }

    private static void ShowLoginMenu()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║          Example App           ║");
        Console.WriteLine("╚════════════════════════════════╝");
        Console.WriteLine();
        Console.Write("Username: ");
        string username = Console.ReadLine() ?? "";
        Console.Write("Password: ");
        string password = Console.ReadLine() ?? "";

        var user = users.Find(u => u.Username == username && u.Password == password);
        
        if (user != null)
        {
            currentUser = user;
            Console.WriteLine($"\n✓ Login berhasil! Selamat datang, {user.Username} ({user.Role})");
            Console.WriteLine("Tekan tombol untuk lanjut...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\n✗ Username atau password salah!");
            Console.WriteLine("Tekan tombol untuk coba lagi...");
            Console.ReadKey();
        }
    }

    private static void ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine($"║  Menu Utama - {currentUser!.Role,-15} ║");
        Console.WriteLine("╚════════════════════════════════╝");
        Console.WriteLine($"User: {currentUser.Username}");
        Console.WriteLine();
        Console.WriteLine("1. Lihat Profil");
        Console.WriteLine("2. Data Karyawan");
        
        if (currentUser.Role == "Admin")
        {
            Console.WriteLine("3. Kelola User (Admin)");
            Console.WriteLine("4. Laporan (Admin)");
        }
        
        Console.WriteLine("5. Ganti Password");
        Console.WriteLine("0. Logout");
        Console.WriteLine();
        Console.Write("Pilih menu: ");
        
        string choice = Console.ReadLine() ?? "";
        ProcessMenu(choice);
    }

    private static void ProcessMenu(string choice)
    {
        Console.Clear();
        
        switch (choice)
        {
            case "1":
                ShowProfile();
                break;
            case "2":
                ShowEmployeeData();
                break;
            case "3":
                if (currentUser!.Role == "Admin")
                    ManageUsers();
                else
                    Console.WriteLine("✗ Akses ditolak! Menu hanya untuk Admin.");
                break;
            case "4":
                if (currentUser!.Role == "Admin")
                    ShowReports();
                else
                    Console.WriteLine("✗ Akses ditolak! Menu hanya untuk Admin.");
                break;
            case "5":
                ChangePassword();
                break;
            case "0":
                currentUser = null;
                Console.WriteLine("✓ Logout berhasil!");
                Console.ReadKey();
                return;
            default:
                Console.WriteLine("✗ Pilihan tidak valid!");
                break;
        }
        
        Console.WriteLine("\nTekan tombol untuk kembali...");
        Console.ReadKey();
    }

    private static void ShowProfile()
    {
        Console.WriteLine("═══ PROFIL USER ═══");
        Console.WriteLine($"Username: {currentUser!.Username}");
        Console.WriteLine($"Role: {currentUser.Role}");
        Console.WriteLine($"Status: Aktif");
    }

    private static void ShowEmployeeData()
    {
        Console.WriteLine("═══ DATA KARYAWAN ═══");
        Console.WriteLine("1. Andi - Developer - 25 tahun");
        Console.WriteLine("2. Budi - Designer - 28 tahun");
        Console.WriteLine("3. Citra - Manager - 32 tahun");
    }

    private static void ManageUsers()
    {
        Console.WriteLine("═══ KELOLA USER (ADMIN) ═══");
        Console.WriteLine("Total User Terdaftar: " + users.Count);
        Console.WriteLine();
        foreach (var user in users)
        {
            Console.WriteLine($"- {user.Username} ({user.Role})");
        }
    }

    private static void ShowReports()
    {
        Console.WriteLine("═══ LAPORAN (ADMIN) ═══");
        Console.WriteLine("Laporan Bulanan: November 2025");
        Console.WriteLine("Total Transaksi: 150");
        Console.WriteLine("Pendapatan: Rp 50.000.000");
    }

    private static void ChangePassword()
    {
        Console.WriteLine("═══ GANTI PASSWORD ═══");
        Console.Write("Password Lama: ");
        string oldPass = Console.ReadLine() ?? "";
        
        if (oldPass == currentUser!.Password)
        {
            Console.Write("Password Baru: ");
            string newPass = Console.ReadLine() ?? "";
            currentUser.Password = newPass;
            Console.WriteLine("✓ Password berhasil diubah!");
        }
        else
        {
            Console.WriteLine("✗ Password lama salah!");
        }
    }
}