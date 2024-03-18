class Math : Assignment {
    protected string _section;
    protected string _problems;
    
    public Math(string student, string topic, string section, string proplems) : base(student, topic) {
        _section = section;
        _problems = proplems;
    }

    public string GetHomeWorkList() {
        return $"Section {_section} Problems {_problems}";
    }
}