class Entry
{
    // DO NOT INCLUDE VARIABLES LIKE THIS
    // public string Response {get; set;}
    // This is a Property

    // Attributes
    public string _date;
    public string _prompt;
    public string _response;

    // Functions
    public void Display()
    {
        Console.WriteLine($"{_date} -- {_prompt} \n {_response}");
    }
}