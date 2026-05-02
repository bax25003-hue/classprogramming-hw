// class Resume
// string _name; List _jobs;
// Display(): First the name then each job

using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs)
        {
            job.DisplayDetails();
        }
    }
}