class ItemManager {
    public List<Item> items = new List<Item>();

    public Item this[int i] {
        get => items[i];
    }
    
    public ItemManager(List<Item> newItems = null) {
        if (newItems == null) {
            items = SaverLoader.OpenItems();
        }
        else {
            items = newItems;
        }
    }

    public int SelectItem() {
        int itemNumber = 1;
        foreach (Item item in items) {
            Console.WriteLine($"{itemNumber}. {item.Display()}");
        }
        Console.WriteLine("Select Item Number");
        return int.Parse(Console.ReadLine()) - 1;
    }

    public void Purchase(int index) {
        this[index].Purchase();
    }

    public void Display() {
        Console.WriteLine($"{items[0].Display()}");
    }
}