class Resume {
    
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    
    public Resume(string name) {
        this._name = name;
    }

    public void display() {
        Console.WriteLine("+" + "+".PadLeft(71, '-'));
        Console.WriteLine($"| {this._name}".PadRight(70) + " |");
        Console.WriteLine($"| Jobs:".PadRight(70) + " |");

        foreach (Job job in this._jobs) {
            job.display();
        }
        Console.WriteLine("+" + "+".PadLeft(71, '-'));
    }
    
}