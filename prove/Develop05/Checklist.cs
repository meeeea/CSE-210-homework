class Checklist : Goal {
    private int _completionMult;

    private Steps _steps = new Steps();

    public Checklist(int score, string name, string[] steps, int completionMult = 5) : base(score, name) {
        _completionMult = completionMult;
        _steps = new Steps(steps);
    }

    public override int Score { get {
            int index = _steps.GetNextUncompletedIndex();
            if (index == _steps.Count - 1) {
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

        return $"{CompletedBox()} {_name} - ({_steps[index].Key}) ({Score}) -- Completed ({k}/{_steps.Count})";
    }

    protected override void Complete(){
        _steps.Complete(_steps.GetNextUncompletedIndex());

    }
}