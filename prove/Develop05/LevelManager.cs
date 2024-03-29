class LevelManager {
    private int _totalScore;
    public int Score => _totalScore;
    private int _level;

    public int ScoreToLevel => Convert.ToInt32((_level/.67F * (_level/.67F)) + 100);

    public LevelManager(int score =0, int level = 1) {
        _totalScore = score;
        _level = level;
    }

    public void CalcScore(int score) {
        _totalScore += score;
        LevelCheck();
    }

    private void LevelCheck() {
        if (_totalScore >= ScoreToLevel) {
            _totalScore -= Convert.ToInt32(ScoreToLevel);
            _level ++;
            LevelUpMessage();
            LevelCheck();
        }
    }

    private void LevelUpMessage() {
        Console.WriteLine($" level {_level - 1} -> {_level}!!!");
    }

    public void Write(StreamWriter writer) {
        writer.Write($"{_totalScore}|{_level}");
    }

    public void Display() {
        Console.WriteLine($"Level {_level} - {{{Score}/{ScoreToLevel}}}");
    }
}