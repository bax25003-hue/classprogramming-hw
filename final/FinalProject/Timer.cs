public class Timer
{
    // Datetime wait and stuff

    // Attributes
    private DateTime? _startTime;
    private DateTime _endTime;
    
    // Behaviors
    public Timer(DateTime? startTime = null)
    {
        _startTime = startTime;
    }
    public void StartTimer(DateTime startTime)
    {
        if (_startTime == null)
        {
            _startTime = startTime;
        }
        else
        {
            throw new InvalidOperationException("This timer has already been started!");
        }
    }
    public TimeSpan Timestamp() // Works for both getting a timestamp and stopping a timer, the program will also remove the timer if it is stopped.
    {
        if (_startTime != null)
        {
            DateTime originalStartTime = (DateTime)_startTime;
            TimeSpan timeStamp = DateTime.Now - originalStartTime;
            return timeStamp;
        }
        else
        {
            throw new InvalidOperationException("You haven't started this timer yet!");
        }
    }
    public string MinutesAndSeconds()
    {
        TimeSpan rawTime = this.Timestamp();
        string timerString = $"{(int)rawTime.TotalMinutes}:{rawTime.Seconds}";
        return timerString;
    }
    public string MinutesAndSeconds(TimeSpan rawTime)
    {
        string timeString = $"{(int)rawTime.TotalMinutes}:{rawTime.Seconds}";
        return timeString;
    }
}