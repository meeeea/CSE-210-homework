class SuplyVaryInfo : VaryInfo {
    public SuplyVaryInfo(float baseValue, float modifier) : base(baseValue, modifier) {}
    public override void CalculateMod()
    {
        throw new NotImplementedException();
    }

    public override string Display() {
        return $"{_baseValue:F2}";
    }

    public float Cost() {
        return _baseValue;
    }
}