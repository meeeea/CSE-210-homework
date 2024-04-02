class SuplyVaryInfo : VaryInfo {
    public SuplyVaryInfo(float baseValue, float modifier) : base(baseValue, modifier) {}
    public override void CalculateNewPrice()
    {
        throw new NotImplementedException();
    }
}