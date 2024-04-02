class DemandVaryInfo : VaryInfo {
    public DemandVaryInfo(float baseValue, float modifier) : base(baseValue, modifier) {}
    public override void CalculateMod()
    {
        throw new NotImplementedException();
    }
}