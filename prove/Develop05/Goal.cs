abstract class Goal {
    protected int _score;
    protected string _name;
    protected bool _isComplete;

    public bool IsComplete => _isComplete;

    public Goal(int score, string name) {
        _score = score;
        _name = name;
        _isComplete = false;
    }

    public abstract int Score {get;}

    public abstract string Display();

    protected abstract int Complete();

    protected string CompletedBox() {
        if (IsComplete) {
            return "[X]";
        }
        return "[ ]";
    }

    public int CompleteScore() {
        return Complete();
    }
}