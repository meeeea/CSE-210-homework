abstract class VaryInfo {
    float _baseValue;
    float _priceChangeModifier;

    public VaryInfo(float baseValue, float modifier) {
        _baseValue = baseValue;
        _priceChangeModifier = modifier;
    }
    public abstract void CalculateNewPrice();
}