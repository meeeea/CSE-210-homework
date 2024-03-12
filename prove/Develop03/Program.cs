using System;


// mine determines a random number of words to remove each time between 2 and 5.

class Program
{
    private static Scripture scripture = new Scripture("Mosiah 5:7-9", "And now, because of the covenant which ye have made ye shall be called the children of Christ, his sons, and his daughters; for behold, this day he hath spiritually begotten you; for ye say that your hearts are changed through faith on his name; therefore, ye are born of him and have become his sons and his daughters. \n" +
"And under this head ye are made free, and there is no other head whereby ye can be made free. There is no other name given whereby salvation cometh; therefore, I would that ye should take upon you the name of Christ, all you that have entered into the covenant with God that ye should be obedient unto the end of your lives. \n" +
"And it shall come to pass that whosoever doeth this shall be found at the right hand of God, for he shall know the name by which he is called; for he shall be called by the name of Christ.");

    static void Main(string[] args)
    {
        while (true) {
            Console.Clear();
            Display();
            if (CheckIfDone()) {
                Console.WriteLine("Congratulations, you completed it all");
                break;
            }
            if (!PromptUser()) {
                Console.WriteLine("Thanks For playing");
                break;
            }
        }
    }

    static bool CheckIfDone() {
        return scripture.IsAllBlank();
    }

    static bool PromptUser() {
        Console.WriteLine("Press enter to continue, type 'quit' to quit.");
        string response = Console.ReadLine();
        if (response == "") {
            scripture.EraseWords(new Random().Next(2,5));
            return true;
        }
        return false;
    }
    
    static void Display() {
        Console.WriteLine(scripture.Display());
    }
}