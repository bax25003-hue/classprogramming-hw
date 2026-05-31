class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private bool _isCompleted;

    public Scripture(string book, int chapter, int startVerse, List<string> initWords, int endVerse = 0)
    {
        // Calls reference constructor
        if (endVerse == 0)
        {
            _reference = new Reference(book, chapter, startVerse);
        }
        else
        {
            _reference = new Reference(book, chapter, startVerse, endVerse);
        }

        // Initializes Word objects from the list of word strings
        List<Word> dummyWordList = new List<Word>();
        for (int i = 0; i < initWords.Count; i++)
        {
            Word word = new Word(initWords[i]);
            dummyWordList.Add(word);
            if (dummyWordList.Count == initWords.Count)
            {
                _words = dummyWordList;
            }
        }
        _isCompleted = false;

    }

    public void DisplayScripture()
    {
        Console.Write($"{_reference.GetReference()} ");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        // Hides three random words
        for (int i = 0; i < 3; i++)
        {
            Random random = new Random();
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }
    public bool GetCompletion()
    {
        return _isCompleted;
    }
    public void SetCompletion(bool completed)
    {
        _isCompleted = completed;
    }
    public bool CheckCompletion()
    {
        // Checks if all words are hidden
        foreach (Word word in _words)
        {
            if (!word.CheckHidden())
            {
                return false;
            }
        }
        return true;
    }
}