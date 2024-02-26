using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("First Name: ");
        string first_name = Console.ReadLine();

        Console.WriteLine("Last Name: ");
        string last_name = Console.ReadLine();
        
        Console.WriteLine($"Hello {first_name} {last_name}");
    }
}