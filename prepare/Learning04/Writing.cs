class Writing : Assignment {
    protected string _title;
    public Writing(string student, string topic, string title) : base(student, topic) {
        _title = title;
    }

    public string GetWritingInformation() {
        return $"{_title} by {_student}";
    }
}