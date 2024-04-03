abstract class Item {
    protected string _name;
    protected string Name => _name;
    protected DemandVaryInfo _demand;
    protected int  _inventory;
    public bool InStock => _inventory > 0;
    protected SuplyVaryInfo _wholeSalePrice;
    protected float _retailPrice;

    public Item(string name, float wsp, float wsm, float d, float dm,
                int inventory, float retailPrice) {
        _demand = new DemandVaryInfo(d, dm);
        _wholeSalePrice = new SuplyVaryInfo(wsp, wsm);
        _name = name;
        _inventory = inventory;
        _retailPrice = retailPrice;
    }

    public abstract int CalculateSales();

    public abstract string Display();

    public abstract string Save();

    public void Purchase() {
        _inventory++;
    }

    public void SetRetailPrice(float price) {
        _retailPrice = price;
    }
}