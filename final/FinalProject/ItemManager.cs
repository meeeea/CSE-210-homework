class ItemManager {
    private List<Item> _items = new List<Item>();

    public Item this[int i] {
        get => _items[i];
    }
    public ItemManager() {
        _items = SaverLoader.OpenItems();
    }
    public ItemManager(List<Item> newItems) {
        _items = newItems;
    }

    public int SelectItem() {
        int itemNumber = 1;
        foreach (Item item in _items) {
            Console.WriteLine($"{itemNumber}. {item.Display()}");
            itemNumber++;
        }
        Console.WriteLine("Select Item Number");
        return int.Parse(Console.ReadLine()) - 1;
    }

    public static int SelectItem(List<Item> items) {
        int itemNumber = 1;
        foreach (Item item in items) {
            Console.WriteLine($"{itemNumber}. {item.Display()}");
            itemNumber++;
        }
        Console.WriteLine("Select Item Number");
        return int.Parse(Console.ReadLine()) - 1;
    }

    public Item SelectItemInInventory() {
        List<Item> theItems = new List<Item>();
        foreach (Item item in _items) {
            if (item.InStock) {
                theItems.Add(item);
            }
        }
        if (theItems.Count == 0) {
            return null;
        }
        return theItems[SelectItem(theItems)];
    }

    public float Purchase(int index, int quantity = 1) {
        return this[index].Purchase(quantity);
    }

    public void Display() {
        foreach (Item item in _items) {
            Console.WriteLine(item.Display());
        }
    }

    public void Save(StreamWriter writer) {
        foreach (Item item in _items) {
            writer.WriteLine(item.Save());
        }
    }

    public float CalculateSales() {
        float total = 0;
        foreach (Item item in _items) {
            total += item.CalculateSales();
        }
        return total;
    }

    public float QuotePrice(int index, int quantity = 1) {
        return this[index].Cost * quantity;
    }

    public void DisplayInventory() {
        bool emptyInventory = true;
        foreach (Item item in _items) {
            if (item.InStock) {
                Console.WriteLine(item.Display());
                emptyInventory = false;
            }
        }
        if (emptyInventory) {
            Console.WriteLine("It apears that you have nothing in invntory");
        }
    }
}