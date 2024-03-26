
class Checklist : Goal {
    private int _completionMult;

    private Steps _steps = new Steps();

    public Checklist(int score, string name, string[] steps, int completionMult = 5) : base(score, name) {
        _completionMult = completionMult;
        _steps = new Steps(steps);
    }

    public Checklist(int score, string name, Steps steps, int completionMult = 5) : base(score, name) {
        _completionMult = completionMult;
        _steps = steps;
    }

    public override int Score { get {
            int index = _steps.GetCompletedCount();
            if (index == _steps.Count) {
                _isComplete = true;
                return _score * _completionMult;
            }
            else {
                return _score;
            };
        }
    }
    public int NextScore { get {
            int index = _steps.GetCompletedCount() + 1;
            if (index >= _steps.Count) {
                return _score * _completionMult;
            }
            else {
                return _score;
            };
        }
    }

    public override string Display() {
        int index = _steps.GetNextUncompletedIndex();
        int k = _steps.GetCompletedCount();

        return $"{CompletedBox()} {_name} - ({_steps[index].Key}) ({NextScore}) -- Completed ({k}/{_steps.Count})";
    }

    protected override int Complete(){
        _steps.Complete(_steps.GetNextUncompletedIndex());
        return Score;
    }

    public override void Save(StreamWriter writer) {
        writer.Write($"\nChecklist|{_name}|");
        _steps.Save(writer);
        writer.Write($"{_score}|{_completionMult}");
    }
}