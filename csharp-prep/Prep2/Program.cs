using System;

class Program
{
    static void Main(string[] args)
    {
        int result;
        while (true) {
            try {
                Console.WriteLine("Grade: ");
                result = Int32.Parse(Console.ReadLine());
            }
            catch {
                continue;
            }
            break;
        }
        bool passes = false;
        string grade = "f";

        if (result >= 90) {
            grade = "a";
            passes = true;
        }
        else if (result >= 80) {
            grade = "b";
            passes = true;
        }
        else if (result >= 70) {
            grade = "c";
            passes = true;
        }
        else if (result >= 60) {
            grade = "d";
        }

        if (passes) {
            Console.WriteLine($"Congradulations, you passed with a(n) {grade}");
        }
        else {
            Console.WriteLine($"Saddly, you failed with a(n) {grade}");
        }
    }
}