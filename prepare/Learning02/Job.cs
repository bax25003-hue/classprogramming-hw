using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography.X509Certificates;

public class Job
{
    // Job information
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Behaviors
    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}