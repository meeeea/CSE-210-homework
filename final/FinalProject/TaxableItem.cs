class TaxableItem : Item {
    public TaxableItem(string name, float wsp, float wsm, float d, float dm,
                int inventory, float retailPrice) : base(name, wsp, wsm, d, dm,
                                                    inventory, retailPrice) {}

    public override int CalculateSales()
    {
        throw new NotImplementedException();
    }

    public override string Display()
    {
        return $"{_name}: {_inventory} in stock, whole sale price: {_wholeSalePrice.Display()}, " +
             $"retail price: {_retailPrice.ToString("F2")}";
    }
}