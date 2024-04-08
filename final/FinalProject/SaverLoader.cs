class SaverLoader {
    public static void Save(StoreManager storeManager) {
        Console.WriteLine("Input Save Name");
        string FileLocation = Console.ReadLine();
        using (StreamWriter writer = File.CreateText($"saves\\{FileLocation}.txt")) {
            writer.WriteLine($"{storeManager.Cycle}|{storeManager.Money}|{storeManager.TaxRate}|{storeManager.Seed}");
            storeManager.Items.Save(writer);
        }
    }

    public static StoreManager Load() {
        try {
            Console.WriteLine("Input Save Name");
            string FileLocation = Console.ReadLine();
            List<Item> items = new List<Item>();
            using (StreamReader reader = File.OpenText($"saves\\{FileLocation}.txt")) {
                string[] firstLine = reader.ReadLine().Split('|');
                while (true) {
                    string line = reader.ReadLine();
                    if (line == null) {break;}
                    string[] LI = line.Split('|');
                    Item lineItem;
                    if (LI[7] == "1") {
                        lineItem = new TaxableItem(LI[0], float.Parse(LI[1]), float.Parse(LI[2]),
                        float.Parse(LI[3]), float.Parse(LI[4]), int.Parse(LI[5]), float.Parse(LI[6]));
                    }
                    else {
                        lineItem = new NonTaxableItem(LI[0], float.Parse(LI[1]), float.Parse(LI[2]),
                        float.Parse(LI[3]), float.Parse(LI[4]), int.Parse(LI[5]), float.Parse(LI[6]));
                    }
                    items.Add(lineItem);
                }
                return new StoreManager(firstLine, new ItemManager(items));
            }
        }
        catch (FileNotFoundException) {
            Console.WriteLine("Could not find save file in saves folder, please " +
                                "ensure that you have FinalProject as your root forlder");
            return new StoreManager();
        }
    }

    public static List<Item> OpenItems() {
        try {
            List<Item> items = new List<Item>();
            using (StreamReader reader = File.OpenText("Dependencies\\Items.txt")) {
                reader.ReadLine();
                while (true) {
                    string line = reader.ReadLine();
                    if (line == null) {break;}
                    string[] LI = line.Split('|');
                    Item lineItem;
                    if (LI[7] == "1") {
                        lineItem = new TaxableItem(LI[0], float.Parse(LI[1]), float.Parse(LI[2]),
                        float.Parse(LI[3]), float.Parse(LI[4]), int.Parse(LI[5]), float.Parse(LI[6]));
                    }
                    else {
                        lineItem = new NonTaxableItem(LI[0], float.Parse(LI[1]), float.Parse(LI[2]),
                        float.Parse(LI[3]), float.Parse(LI[4]), int.Parse(LI[5]), float.Parse(LI[6]));
                    }
                    items.Add(lineItem);
                }
            }
            return items;
        }
        catch (FileNotFoundException) {
            Console.WriteLine("Could not find Items.txt in Dependencies folder, " +
                                "ensure that you have FinalProject as your root forlder");
            Environment.Exit(2);
            return new List<Item>();
        }
    }
}