class Assignment {
    protected string _student;
    protected string _topic;

    public Assignment(string student, string topic) {
        _student = student;
        _topic = topic;
    }

    public string GetSummery() {
        return $"{_student} - {_topic}";
    }
}