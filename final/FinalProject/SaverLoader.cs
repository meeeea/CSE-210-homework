using System.Runtime.CompilerServices;

class SaverLoader {
    public static void Save(StoreManager storeManager) {
        throw new NotImplementedException();
    }

    public static StoreManager Load() {
        throw new NotImplementedException();
    }

    public static List<Item> OpemItems() {
        try {
            List<Item> items = new List<Item>();
            using (StreamReader reader = File.OpenText("Dependencies\\Items.txt")) {
                while (true) {
                    string line = reader.ReadLine();
                    if (line == null) {break;}
                    string[] LI = line.Split('|');
                    if (LI[7] == "1") {
                        Item lineItem = new TaxableItem(LI[0], float.Parse(LI[1]), float.Parse(LI[2]),
                        float.Parse(LI[3]), float.Parse(LI[4]), int.Parse(LI[5]), float.Parse(LI[6]));
                
                    }
                }
            }
            return items;
        }
        catch (FileNotFoundException) {
            Console.WriteLine("Could not find Items.txt in Dependencies folder," +
                                "ensure that you have FinalProject as your root forlder");
            Environment.Exit(2);
            return new List<Item>();
        }
    }
}