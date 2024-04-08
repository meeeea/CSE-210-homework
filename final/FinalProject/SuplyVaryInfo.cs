class SuplyVaryInfo : VaryInfo {
    public SuplyVaryInfo(float baseValue, float modifier, float elacticity = 1) : 
                            base(baseValue, modifier, elacticity) {}

    public override void CalculateMod() {
        _baseValue += RandomGen() * _priceChangeModifier;
    }

    public override string Display() {
        return $"{_baseValue:F2}";
    }

    public float Cost() {
        return _baseValue;
    }
}