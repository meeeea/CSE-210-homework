class Steps {
    // the bool is for completed or not
    private List<KeyValuePair<string, bool>> _steps = new List<KeyValuePair<string, bool>>();

    public KeyValuePair<string, bool> this[int x] {
        get => _steps[x];
    }

    public int Count => _steps.Count;

    public Steps(string[] steps) {
        foreach (string step in steps) {
            _steps.Add(new KeyValuePair<string, bool>(step, false));
        }
    }

    public Steps() {}

    public void Complete(int index) {
        string key = _steps[index].Key;
        _steps[index] = new KeyValuePair<string, bool>(key, true);
    }

    public int GetNextUncompletedIndex() {
        foreach (KeyValuePair<string, bool> keyValuePair in _steps) {
            if (!keyValuePair.Value) {
                return _steps.IndexOf(keyValuePair);
            }
        }
        return _steps.Count - 1;
    }
    public int GetCompletedCount() {
        int i = 0;
        foreach (KeyValuePair<string, bool> keyValuePair in _steps) {
            if (keyValuePair.Value) {
                i++;
            }
        }
        return i;
    }

    public void Add(string name, bool isComplete) {
        _steps.Add(new KeyValuePair<string, bool>(name, isComplete));
    }

    public void Save(StreamWriter writer) {
        foreach (KeyValuePair<string, bool> keyValuePair in _steps) {
            Console.WriteLine("help");
            int intBool = keyValuePair.Value == true ? 1 : 0;
            writer.Write($"{keyValuePair.Key}|{intBool}|");
        }
    }
}