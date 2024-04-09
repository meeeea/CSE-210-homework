class NonTaxableItem : Item {
    public NonTaxableItem(string name, float wsp, float wsm,
                             float d, float dm, int inventory, float retailPrice) :
                            base(name, wsp, wsm, d, dm, inventory, retailPrice) {}

    public override float CalculateSales() {
        if (!InStock) {return 0.0F;}

        int quantity = int.Clamp(_demand.QuantityToPurchase(_retailPrice), 0, _inventory);
        _inventory -= quantity;
        float total = quantity * _retailPrice;
        Console.WriteLine($"Number of {_name} sold: {quantity}, TotoalProfit {total:F2}");

        _wholeSalePrice.CalculateMod();
        _demand.CalculateMod();

        return total;
    }

    public override string Display() {
        return  $"{_name}:".PadLeft(25) + $" {_inventory} in stock, whole sale price: "+ 
            $"{_wholeSalePrice.Display()}, retail price: {_retailPrice:F2}.";
    }

        public override string Save() {
        return $"{_name}|{_wholeSalePrice.Save()}|{_demand.Save()}|{_inventory}|{_retailPrice}|0";
    }
}