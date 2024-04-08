class DemandVaryInfo : VaryInfo {
    public static float Scale => Program.storeManager.Scale;

    public DemandVaryInfo(float baseValue, float modifier) : 
                            base(baseValue, modifier) {}
    
    public int QuantityToPurchase(float price) {
        float quantityBase = (price - _baseValue) / (_baseValue * _elacticity) + Scale;
        return (int)Math.Round(quantityBase * quantityBase);
    }

    public override void CalculateMod() {
        _baseValue += RandomGen() * _priceChangeModifier;
        _elacticity += (float) Math.Sqrt(RandomGen()) / 2;
    }
    public override string Display() {
        return "This function is never called";
    }
}