
class Event : Goal {    
    public Event(int score, string name, bool completed = false) : base(score, name) {
        _isComplete = completed;
    }

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

    public override void Save(StreamWriter writer) {
        writer.Write("\nEvent|");

        writer.Write(_name);

        if (IsComplete) {
            writer.Write("|1|");
        }
        else {
            writer.Write("|0|");
        }
        writer.Write(_score);
    }
}