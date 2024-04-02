class ItemManager {
    public List<Item> items = new List<Item>();

    public Item this[int i] {
        get => items[i];
    }
    
    public ItemManager() {
        items = SaverLoader.OpemItems();
    }

    public int SelectItem() {
        int itemNumber = 1;
        foreach (Item item in items) {
            Console.WriteLine($"{itemNumber}. {item.Display()}");
        }
        Console.WriteLine("Select Item Number");
        return int.Parse(Console.ReadLine()) - 1;
    }
}