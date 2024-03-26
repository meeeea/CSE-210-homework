class Repeter : Goal {
    public Repeter(int score, string name) : base(score, name) {}

    public override int Score => _score;

    public override string Display(){
        return $"[O] {_name} ({Score})";
    }

    protected override int Complete() => Score;
}