abstract class Item {
    private string _name;
    public string Name => _name;
    private DemandVaryInfo _demand;
    private int  _inventory;
    private SuplyVaryInfo _wholeSalePrice;
    private float _retailPrice;

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
}