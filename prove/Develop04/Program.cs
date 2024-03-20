using System;

class Program
{
    static void Main(string[] args)
    {
        while(true) {
            Console.WriteLine("1). Breathing Activity");
            Console.WriteLine("2). Reflection Activity");
            Console.WriteLine("3). Listing Activity");
            Console.WriteLine("4). Quit");

            int option = Console.Read() - 48;

            if (option == 1) {
                new BreathingActivity();
            }
            else if (option == 2) {
                new ReflectionActivity();
            }
            else if (option == 3) {
                new ListingActivity();
            }
            else {
                break;
            }
        }
    }
}