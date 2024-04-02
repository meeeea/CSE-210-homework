class DemandVaryInfo : VaryInfo {
    public DemandVaryInfo(float baseValue, float modifier) : base(baseValue, modifier) {}
    public override void CalculateNewPrice()
    {
        throw new NotImplementedException();
    }
}