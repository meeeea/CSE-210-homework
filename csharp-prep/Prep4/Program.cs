using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> the_list = new List<int>();
        while (true) {
            int input;
            try {
                Console.WriteLine("Enter Number: ");
                input = Int32.Parse(Console.ReadLine());
            }
            catch {
                continue;
            }
            if (input == 0 && the_list.Count > 1) {
                break;
            }

            the_list.Add(input);
        }
        int largest = 0;
        int total = 0;
        foreach (int i in the_list) {
            if (largest < i) {
                largest = i;
            }
            total += i;
        }
        float average = (float)total / (float)the_list.Count;

        Console.WriteLine($"The largest number listed was {largest}");
        Console.WriteLine($"The total of the numbers listed was {total}");
        Console.WriteLine($"The average of the numbers listed was {average}");

    }
}