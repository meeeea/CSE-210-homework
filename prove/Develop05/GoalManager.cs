class GoalManager {
    private List<Goal> _goals = new List<Goal>();

    private int _totalScore = 0;

    public void Add(Goal goal) {
        _goals.Add(goal);
    }

    public void Display() {
        for (int i = 0; i < _goals.Count; i ++) {
            Console.WriteLine($"{i + 1}: " + _goals[i].Display());
        }
    }

    public Goal this[int x]{
        get => _goals[x];
    }
}