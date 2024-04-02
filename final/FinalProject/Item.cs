abstract class Item {
    private string _name;
    public string Name => _name;
    private float _demand;
    private float _inventory;
    private float _wholeSalePrice;
    private float _retailPrice;

    public Item(string name, float wholeSalePrice, float demand, 
                float inventory = 0, float retailPrice = 0) {
        _demand = demand;
        _wholeSalePrice = wholeSalePrice;
        _name = name;
        _inventory = inventory;
        _retailPrice = retailPrice;
    }

    public abstract int CalculateSales();
}