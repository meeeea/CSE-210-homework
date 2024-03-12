class Word {
    private string _word;
    private bool _isHiden = false;

    //not a member variable, it's a property
    public string word{
        get {
            if (isHiden) {
                return "".PadRight(_word.Length, '_');
            }
            return _word;}
        set {_word = value;}
    }
    //not a member variable, it's a property
    public bool isHiden {
        get {return _isHiden;}
    }

    public Word(string theWord = "fish") {
        _word = theWord;
    }

    public bool Hide() {
        if (_isHiden) {
            return true;
        }
        _isHiden = true;
        return false;
    }
}