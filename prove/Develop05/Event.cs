class Event : Goal {    
    public Event(int score, string name) : base(score, name) {}

    public override int Score {get {
        if (!IsComplete) {
            _isComplete = true; 
            return _score;
        }
        return 0;
        }
    }

    public override string Display() {
        return $"{CompletedBox()} {_name} ({_score})";
    }
    
    protected override int Complete() {
        _isComplete = true;
        return _score;
    }
}