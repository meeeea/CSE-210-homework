class Repeter : Goal {
    public Repeter(int score, string name) : base(score, name) {}

    public override int Score => _score;

    public override string Display(){
        return $"[O] {_name} ({Score})";
    }

    protected override int Complete() => Score;

    public override void Save(StreamWriter writer) {
        // declare save type
        writer.Write("\nRepeter|");
        // display unique info
        writer.Write($"{_name}|{Score}");
    }
}