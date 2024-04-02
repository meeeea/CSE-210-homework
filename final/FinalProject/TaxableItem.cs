class TaxableItem : Item {
    public TaxableItem(string name, float wholeSalePrice, float demand, float inventory = 0, 
                        float retailPrice = 0) : base(name, wholeSalePrice, demand, 
                                                    inventory, retailPrice) {}

    public override int CalculateSales()
    {
        throw new NotImplementedException();
    }
}