class SuplyVaryInfo : VaryInfo {
    public SuplyVaryInfo(float baseValue, float modifier, float elacticity = 1) : 
                            base(baseValue, modifier, elacticity) {}

    public override void CalculateMod()
    {
        _baseValue += new Random(Seed).Next(-1,1) * _priceChangeModifier;
        _elacticity += (float) Math.Sqrt(new Random(Seed).Next(-1,1)) / 2;
    }

    public override string Display() {
        return $"{_baseValue:F2}";
    }

    public float Cost() {
        return _baseValue;
    }
}