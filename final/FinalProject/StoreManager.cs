using System.Text.RegularExpressions;

class StoreManager {
    ItemManager _items = new ItemManager();

    public StoreManager() {}
    public StoreManager(ItemManager itemManager) {
        _items = itemManager;
    }

    public void MainGameLoop() {
        while (true) {
            Menu();
        }
    }

    private void Menu() {
        Console.WriteLine("1. View Inventory");
        Console.WriteLine("2. Purchase Inventory (TODO)");
        Console.WriteLine("3. Set Item Price (TODO)");
        Console.WriteLine("4. End Cycle (TODO)");
        Console.WriteLine("5. Save Game (TODO)");
        Console.WriteLine("6. Load Game (TODO)");
        Console.WriteLine("7. Quit");

        ExicuteMenu(int.Parse(Console.ReadLine()));
    }

    private void ExicuteMenu(int response) {
        Console.Clear();
        switch (response) {
            case 1:
            ViewInventory(); return;
            case 2:
            PurchaseInventory(); return;
            case 3:
            SetRetailPrice(); return;
            case 4:
            EndCycle(); return;
            case 5:
            Save(); return;
            case 6:
            Load(); return;
            case 7:
            Environment.Exit(1);
            return;
        }
    }
    private void ViewInventory() {
        _items.Display();
    }

    private void PurchaseInventory() {
        int itemToBuy = _items.SelectItem();
        _items.Purchase(itemToBuy);
    }

    private void SetRetailPrice() {
        Item item = _items.SelectItemInInventory();
        if (item == null) {
            Console.WriteLine("Sorry, you don't have any inventory," +
            " please purchase some inventory before setting thier retail price");
            return;
        }
        
        Console.WriteLine(item.Display());
        Console.WriteLine("Set Retail Price (excluding tax).");
        item.SetRetailPrice(float.Parse(Console.ReadLine()));
    }

    private void EndCycle() {
        throw new NotImplementedException();
    }

    private void Save() {
        SaverLoader.Save(this);
    }

    private void Load() {
        StoreManager newSave = SaverLoader.Load();
        _items = newSave._items;
    }
}