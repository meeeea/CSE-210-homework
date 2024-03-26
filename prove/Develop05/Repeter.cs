class Repeter : Goal {
    public Repeter(int score, string name) : base(score, name) {}

    public override int Score => _score;

    public override string Display(){
        return $"{CompletedBox()} {_name} ({Score})";
    }

    protected override void Complete() {}
}