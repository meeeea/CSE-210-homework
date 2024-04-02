using System.Text.RegularExpressions;

class StoreManager {
    ItemManager _items = new ItemManager();

    public void MainGameLoop() {
        while (true) {
            Menu();
        }
    }

    private void Menu() {
        Console.WriteLine("1. Purchase Inventory (TODO)");
        Console.WriteLine("2. Set Item Price (TODO)");
        Console.WriteLine("3. End Cycle (TODO)");
        Console.WriteLine("4. Save Game (TODO)");
        Console.WriteLine("5. Load Game (TODO)");
        Console.WriteLine("6. Quit");

        ExicuteMenu(int.Parse(Console.ReadLine()));
    }

    private void ExicuteMenu(int response) {
        switch (response) {
            case 1:
            PurchaseInventory(); return;
            case 2:
            SetRetailPrice(); return;
            case 3:
            EndCycle(); return;
            case 4:
            Save(); return;
            case 5:
            Load(); return;
            case 6:
            Environment.Exit(1);
            return;
        }
    }

    private void PurchaseInventory() {
        throw new NotImplementedException();
    }

    private void SetRetailPrice() {
        throw new NotImplementedException();
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

    private int GetItemIndex() {
        return _items.SelectItem();
    }
}