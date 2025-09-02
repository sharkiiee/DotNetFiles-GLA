using System;
using System.Collections.Generic;

class UserProfile
{
    private string username;
    private string password;
    private string email;

    public void SetUsername(string name) { username = name; }
    public string GetUsername() { return username; }

    public void SetPassword(string pass)
    {
        if (pass.Length >= 6) password = pass;
        else Console.WriteLine("Password must be at least 6 characters.");
    }
    public string GetPassword() { return password; }

    public void SetEmail(string mail)
    {
        if (mail.Contains("@")) email = mail;
        else Console.WriteLine("Invalid email.");
    }
    public string GetEmail() { return email; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Experiment 1:");
        var user1 = new UserProfile();
        user1.SetUsername("Alice");
        user1.SetPassword("pass123");
        user1.SetEmail("alice@example.com");
        Console.WriteLine($"User: {user1.GetUsername()}, Email: {user1.GetEmail()}");

        var user2 = new UserProfile();
        user2.SetUsername("Bob");
        user2.SetPassword("123");
        user2.SetEmail("bobexample.com");
    }
}