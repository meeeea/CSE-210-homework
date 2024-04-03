abstract class VaryInfo {
    protected float _baseValue;
    protected float _priceChangeModifier;

    public VaryInfo(float baseValue, float modifier) {
        _baseValue = baseValue;
        _priceChangeModifier = modifier;
    }
    public abstract void CalculateMod();

    public abstract string Display();

    public string Save() {
        return $"{_baseValue}|{_priceChangeModifier}";
    }
}