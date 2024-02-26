using System;

class Program
{
    static void Main(string[] args)
    {
        int magic_number = new Random().Next(100);
        
        int guesses = 0;
        while (true) {
            int guess;

            try {
                Console.WriteLine("Guess: ");
                guess = Int32.Parse(Console.ReadLine());
            }
            catch {
                continue;
            }
            if (guess > magic_number) {
                Console.WriteLine("Lower");
                guesses++;
            }
            else if (guess < magic_number) {
                Console.WriteLine("Higher");
                guesses++;
            }
            else {
                Console.WriteLine($"Congratulations, the correct number was {magic_number}");
                Console.WriteLine($"You guessed the correct number in {guesses} attempts");
                break;
            }
        }
    }
}