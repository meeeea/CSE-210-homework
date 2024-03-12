class Scripture {
    private Refference _refference = new Refference("");
    private List<Word> _scripture = new List<Word>();
    public string refference {
        get {return _refference.Display();}
        set {_refference = new Refference(value);}
    }

    public string scripture {
        get {string returnable = "";
            foreach (Word word in _scripture) {
                returnable += word.word + " ";
            }
            return returnable;
        }
        set {foreach (string word in value.Split()) {
                _scripture.Add(new Word(word));
            }
        }
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
            if (_scripture[index].Hide()) {
                i--;
                continue;
            }
        }
    }

    public string Display() {
        return refference + ", " + scripture;
    }

    public bool IsAllBlank() {
        foreach (Word word in _scripture) {
            if (word.isHiden == false) {
                return false;
            }
        }
        return true;
    }


    private int GetScriptureLength() {
        int i = 0;
        foreach (Word word in _scripture) {
            if (word.isHiden == false) {
                i++;
            }
        }
        return i;
    }
}