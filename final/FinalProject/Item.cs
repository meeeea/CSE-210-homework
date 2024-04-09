abstract class Item {
    protected string _name;
    protected string Name => _name;
    protected DemandVaryInfo _demand;
    protected int  _inventory;
    public bool InStock => _inventory > 0;
    protected SuplyVaryInfo _wholeSalePrice;
    public float Cost => _wholeSalePrice.Cost;
    protected float _retailPrice;

    public Item(string name, float wsp, float wsm, float d, float dm,
                int inventory, float retailPrice) {
        _demand = new DemandVaryInfo(d, dm);
        _wholeSalePrice = new SuplyVaryInfo(wsp, wsm);
        _name = name;
        _inventory = inventory;
        _retailPrice = retailPrice;
    }

    public abstract float CalculateSales();

    public abstract string Display();

    public abstract string Save();

    public float Purchase(int quantity = 1) {
        _inventory += quantity;
        return quantity * _wholeSalePrice.Cost;
    }

    public void SetRetailPrice(float price) {
        if (price <= 0) {
            Console.WriteLine("Please input a positive number.");
            return;
        }
        _retailPrice = price;
    }
}