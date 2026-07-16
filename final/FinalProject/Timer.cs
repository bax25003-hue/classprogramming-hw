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
            throw new InvalidOperationException("You already started your workout!");
        }
    }
    public TimeSpan StopTimer()
    {
        if (_startTime != null)
        {
            DateTime originalStartTime = (DateTime)_startTime;
            _endTime = DateTime.Now;
            TimeSpan workoutDuration = _endTime - originalStartTime;
            return workoutDuration;
        }
        else
        {
            throw new InvalidOperationException("You haven't started your workout yet!");
        }
    }
    public TimeSpan TimeStamp()
    {
        if (_startTime != null)
        {
            DateTime originalStartTime = (DateTime)_startTime;
            TimeSpan timeStamp = DateTime.Now - originalStartTime;
            return timeStamp;
        }
        else
        {
            throw new InvalidOperationException("You haven't started your workout yet!");
        }
    }
}