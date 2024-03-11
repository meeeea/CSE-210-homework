using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(3,4);
        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction.GetDecimal());
        Console.WriteLine(fraction1.GetDecimal());
        Console.WriteLine(fraction.GetAsFraction());
        Console.WriteLine(fraction1.GetAsFraction());
    }
}