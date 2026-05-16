using System.IO.Enumeration;

class Journal
{
    // Attributes
    public List<Entry> _entries = new List<Entry>();
    public string _filePath = "";
    Random random = new Random();

    // Functions
    public void AddEntry()
    {
        // Create new Entry class
        Entry newEntry = new Entry();

        // Date
        DateTime newDateTime = DateTime.Now;
        newEntry._date = newDateTime.ToShortDateString();
        Console.Write(newEntry._date);
        Console.Write($" -- "); // Space between date and prompt

        // Prompt
        List<string> promptList = new List<string>();
        promptList = [
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
            "What is a small detail from today that I want to remember a year from now? ",
            "What am I holding onto from today that I need to let go of before I go to sleep?" ,
            "Did I say 'yes' to something today when I really needed or wanted to say 'no'? ",
            "What did I learn about myself through a challenge, mistake, or awkward moment today? ",
        ];
            // Random number between 0 and list item count - 1 (highest index)
        newEntry._prompt = promptList[random.Next(0,promptList.Count()-1)];
        Console.WriteLine(newEntry._prompt);

        // Entry
        newEntry._response = Console.ReadLine();

        // Add newEntry to _entries
        _entries.Add(newEntry);

        // Acknowledge new entry
        Console.WriteLine($"New entry accepted!");
    }
    public void DisplayEntries()
    {
        // Loop to show all entires in the _entries attribute
        if (_entries.Count == 0)
        {
            Console.WriteLine("Error: No entries to display. Please write a new entry or load a journal from file.");
        }
        else
        {
            Console.WriteLine("Displaying entries: \n");
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
    }
    public void Save()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("You have nothing to save! Create an entry or load a file first.");
        }
        else
        {
            // Gets user file name
            Console.Write($"Enter a name for your file: ");
            string journalName = Console.ReadLine();
            // _filePath = $".\\{journalName}.txt";
            _filePath = $".\\{journalName}.csv";

            // Writes each entry to the file 
            using (StreamWriter file = new StreamWriter(_filePath))
            {
                foreach (Entry entry in _entries)
                {
                    // string entryToSave = entry.Display(); 
                    
                    // ^^^ I was initially able to reuse my Entry.Display method to write entries
                    // to the file because I was using a text file and I would iterate through the
                    // text file three lines at a time ( see below )

                    // file.WriteLine($"{entryToSave}"); // The two characters at the end of the file is the entry separator 
                    file.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
    }
    public void Load()
    {
        // Clears attributes
        _entries.Clear();
        _filePath = "";
        
        // Asks the user for a filepath
        Console.Write("Please enter a journal name to load from: ");
        string journalName = Console.ReadLine();
        // _filePath = $".\\{journalName}.txt";
        _filePath = $".\\{journalName}.csv";
        
        // Reads the file
        Console.WriteLine($"Loading from {_filePath}...");
        string[] lines = System.IO.File.ReadAllLines(_filePath);
        int count = lines.Length;
        // for (int i = 0; i < lines.Length - 1; i += 3) // _filePath.Length - 1 ommits the last empty line of the file
        // {
        //     Entry loadingEntry = new Entry();
        //     loadingEntry._date = lines[i];
        //     loadingEntry._prompt = lines[i + 1];
        //     loadingEntry._response = lines[i + 2];
        //     _entries.Add(loadingEntry);
        // }
        for (int i = 0; i < lines.Length; i ++) 
        {   
            Entry loadingEntry = new Entry();

            // Separate line parts to parse for Entry attributes
            string line = lines[i];
            string[] parts = line.Split("~|~");
            
            // Add parts to attributes of loadingEntry
            loadingEntry._date = parts[0];
            loadingEntry._prompt = parts[1];
            loadingEntry._response = parts[2];
            _entries.Add(loadingEntry);
            
        }
    }
}