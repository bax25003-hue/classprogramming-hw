class Journal
{
    // Attributes
    public List<Entry> _entries;
    public string _filePath;
    Random random = new Random();

    // Functions
    public void AddEntry()
    {
        // Create new Entry class
        Entry newEntry = new Entry();

        // Date
        DateTime newDateTime = DateTime.Now;
        newEntry._date = newDateTime.ToShortDateString();

        // Prompt
        List<string> promptList = new List<string>();
        promptList = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is a small detail from today that I want to remember a year from now?",
            "What am I holding onto from today that I need to let go of before I go to sleep?",
            "Did I say 'yes' to something today when I really needed or wanted to say 'no'?",
            "What did I learn about myself through a challenge, mistake, or awkward moment today?",
        ];
        // Random number between 0 and list item count - 1 (highest index)
        newEntry._prompt = promptList[random.Next(0,promptList.Count()-1)];

        // Entry
        newEntry._response = Console.ReadLine();
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            
        }
    }
    public void Save()
    {
        
    }
    public void Load()
    {
        
    }
}