class Word {
    private string _word;
    public string word{
        get {
            if (isHiden) {
                return "".PadRight(_word.Length, '_');
            }
            return _word;}
        set {_word = value;}
    }

    private bool _isHiden = false;
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