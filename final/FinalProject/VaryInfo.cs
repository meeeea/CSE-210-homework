abstract class VaryInfo {
    protected static Random random = new Random(Seed);
    protected float _baseValue;
    protected float _priceChangeModifier;
    protected float _elacticity;
    protected static int Seed => Program.storeManager.Seed;
    public VaryInfo(float baseValue, float modifier, float elacticity = 1f) {
        _baseValue = baseValue;
        _priceChangeModifier = modifier;
        _elacticity = elacticity;
    }
    public abstract void CalculateMod();

    public abstract string Display();

    public string Save() {
        return $"{_baseValue}|{_priceChangeModifier}";
    }

    protected static float RandomGen() {
        double next = random.NextDouble();
        return (float) (-1 + (next * 2));
    }
}