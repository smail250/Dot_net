using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GreetUser(args.Length > 0 ? args[0] : "Guest");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}