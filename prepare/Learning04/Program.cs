using System;

class Program
{
    static void Main(string[] args)
    {
        Math bob = new Math("Bob Smith", "Fractions", "3.4", "6-10");
        Console.WriteLine(bob.GetSummery());
        Console.WriteLine(bob.GetHomeWorkList());

        Writing Marry = new Writing("Marry Stuert", "Modern Europe", "The Causes of World War II");
        Console.WriteLine(Marry.GetSummery());
        Console.WriteLine(Marry.GetWritingInformation());
    }
}