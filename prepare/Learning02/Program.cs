using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume("Bob");
        resume._jobs.Add(new Job("Disney", "Animator", 1930, 2010));
        resume._jobs.Add(new Job("East India Trading Company", "Plantation Manager", 1500, 1530));
        resume.display();
    }
}