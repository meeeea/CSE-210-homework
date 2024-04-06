abstract class VaryInfo {
    protected float _baseValue;
    protected float _priceChangeModifier;
    protected float _elacticity;
    protected int Seed => Program.storeManager.Seed;
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
}