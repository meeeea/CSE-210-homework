using System.ComponentModel.Design.Serialization;
using System.Text.RegularExpressions;

class StoreManager {
    private ItemManager _items = new ItemManager();
    public ItemManager Items => _items;
    private float _money = 100.00F;
    public float Money => _money;
    public float Scale => _cycle ^ 2 / 10;
    private float _taxRate = .0825F;
    public float TaxRate => _taxRate;
    private int _cycle = 1;
    public int Cycle => _cycle;
    private int _seed = new Random().Next();
    public int Seed => _seed;
    
    public StoreManager() {}
    public StoreManager(string[] globals, ItemManager itemManager) {
        _items = itemManager;
        _cycle = int.Parse(globals[0]);
        _money = float.Parse(globals[1]);
        _taxRate = float.Parse(globals[2]);
        _seed = int.Parse(globals[3]);
    }

    public void MainGameLoop() {
        while (true) {
            Menu();
        }
    }

    private void Menu() {
        Console.WriteLine("1. View Inventory");
        Console.WriteLine("2. Purchase Inventory");
        Console.WriteLine("3. Set Item Price");
        Console.WriteLine("4. End Cycle");
        Console.WriteLine("5. Save Game");
        Console.WriteLine("6. Load Game");
        Console.WriteLine("7. Quit");

        try {
            ExicuteMenu(int.Parse(Console.ReadLine()));
        }
        catch {
            Console.WriteLine("Sorry, something went wrong, Try again.");
        }
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
        Console.WriteLine($"{_money:F2}");
        _items.DisplayInventory();
    }

    private void PurchaseInventory() {
        int itemToBuy = _items.SelectItem();
        Console.WriteLine($"How many would you like to purchase at {_items.QuotePrice(itemToBuy):F2}");
        int quantity = int.Parse(Console.ReadLine());
        if (_items.QuotePrice(itemToBuy, quantity) > _money) {
            Console.WriteLine("Sorry, you can not afford that much");
            return;
        }
        else if (quantity < 1) {
            Console.WriteLine("Quantity must be positive.");
            return;
        }
        _money -= _items.Purchase(itemToBuy, quantity);
    }

    private void SetRetailPrice() {
        Item item = _items.SelectItemInInventory();
        if (item == null) {
            Console.WriteLine("Sorry, you don't have any inventory," +
            " please purchase some inventory before setting thier retail price");
            return;
        }
        
        Console.WriteLine(item.Display());
        Console.WriteLine("Set Retail Price (excluding tax if applicable).");
        item.SetRetailPrice(float.Parse("0" + Console.ReadLine()));
    }

    private void EndCycle() {
        Console.WriteLine($"End of cycle {_cycle}");
        _money += _items.CalculateSales();
        
        float rent = (float) (Scale + Math.Pow(Scale, 2)) / 1000 + 5;
        if (rent > _money) {
            GameOver(rent);
        }
        Console.WriteLine($"Rent ${rent:F2}");
        _money -= rent;
        
        _cycle += 1;
        Console.WriteLine($"Begining of cycle {_cycle}");
    }

    private void Save() {
        SaverLoader.Save(this);
    }

    private void Load() {
        StoreManager storeManager = SaverLoader.Load();
        this.Copy(storeManager);
    }

    public void GameOver(float rent) {
        Console.WriteLine($"Sorry, you couldn't pay rent by {rent - Money:F2}.");
        Console.WriteLine($"Your store lasted {Cycle} cycles.");
        Console.WriteLine("Thank You For Playing");
        Environment.Exit(1);
    }
    
    private void Copy(StoreManager storeManager) {
        _cycle = storeManager.Cycle;
        _items = storeManager.Items;
        _money = storeManager.Money;
        _seed = storeManager.Seed;
        _taxRate = storeManager.TaxRate;
    }
}