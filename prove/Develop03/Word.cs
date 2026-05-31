class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string initText)
    {
        _text = initText;
        _isHidden = false;
    }
    public string GetWord()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            char[] hiddenWord = _text.ToCharArray();
            for (int i = 0; i < hiddenWord.Length; i++)            {
                hiddenWord[i] = '_';
            }
            return new string(hiddenWord);
        }
    }
    public void SetWord(string input)
    {
        _text = input;
    }
    public void Hide()
    // Returns whether the word his hidden or not, bool
    {
        // Hides word if not hidden
        if (_isHidden == false)
        {
            _isHidden = true;
        }
    }
    public bool CheckHidden()
    {
        // Returns true if hidden, else false
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}