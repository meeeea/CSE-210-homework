using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome To The Program");
    }

    static string PromptUserName() {
        Console.WriteLine("What is Your Name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber() {
        int result;
        while (true) {
            try {
                Console.WriteLine("What is Your Favorite Number: ");
                result = Int32.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Please Input a Number.");
                continue;
            }
            return result;
        }
    }

    static int SquareNumber(int input) {
        return input * input;
    }

    static void DisplayResult(string name, int square) {
        Console.WriteLine($"{name}, the square of your number in {square}");
    }
}