class Entry
{
    // DO NOT INCLUDE VARIABLES LIKE THIS
    // public string Response {get; set;}
    // This is a Property, and we haven't learned about those yet

    // Attributes
    public string _date;
    public string _prompt;
    public string _response;

    // Functions
    public string Display()
    {
        string entryToDisplay = $"Date: {_date}\n{_prompt} -- {_response}";
        Console.WriteLine(entryToDisplay);
        return entryToDisplay;
    }
}