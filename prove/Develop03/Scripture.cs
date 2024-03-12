class Scripture {
    private string _refference = "";
    private List<string> _scripture;
    private List<int> _convertedIndexes = new List<int>();

    public string refference {
        get {return _refference;}
        set {_refference = value;}
    }

    public string scripture {
        get {string returnable = "";
            foreach (string word in _scripture) {
                returnable += word + " ";
            }
            return returnable;}
        set {_scripture = new List<string>(value.Split());}
    }

    public Scripture(string theRefference, string theScripture) {
        refference = theRefference;
        scripture = theScripture;
    }



    public void EraseWords(int quantity) {
        if (quantity > GetScriptureLength()) {
            quantity = GetScriptureLength();
        }
        Random random = new Random();
        for (int i = 0; i < quantity; i++) {
            int index = random.Next(_scripture.Count);
            if (_convertedIndexes.Contains(index)) {
                i--;
                continue;
            }
            else {
                EraseWord(index);
            }
        }
    }

    public string Display() {
        return refference + ", " + scripture;
    }

    public bool IsAllBlank() {
        if (GetScriptureLength() == 0) {
            return true;
        }
        return false;
    }
    
    private void EraseWord(int index) {
        int wordLength = _scripture[index].Length;
        _scripture[index] = "".PadRight(wordLength, '_');
        _convertedIndexes.Add(index);
    }

    private int GetScriptureLength() {
        return _scripture.Count - _convertedIndexes.Count;
    }
}