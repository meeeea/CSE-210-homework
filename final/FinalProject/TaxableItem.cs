class TaxableItem : Item {
    public TaxableItem(string name, float wsp, float wsm, float d, float dm,
                int inventory, float retailPrice) : base(name, wsp, wsm, d, dm,
                                                    inventory, retailPrice) {}

    public override int CalculateSales() {
        throw new NotImplementedException();
    }

    public override string Display() {
        return $"{_name}:".PadLeft(15) + $" {_inventory} in stock, whole sale price: "+ 
            $"{_wholeSalePrice.Display()}, retail price: {_retailPrice:F2} + Tax.";
    }

    public override string Save() {
        return $"{_name}|{_wholeSalePrice.Save()}|{_demand.Save()}|{_inventory}|{_retailPrice}|1";
    }
}