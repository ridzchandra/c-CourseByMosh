namespace IntermediateByMosh.Classes.Excercises;

public class Stopwatch
{
  private static DateTime _startTime;
  public static TimeSpan Duration { get; private set; }
  public static void Start()
  {
    if (_startTime != default)
    {
      throw new InvalidOperationException("You can't start the stopwatch while it's already running!"
      );
    }

    _startTime = DateTime.Now;

  }
  public static void Stop()
  {
    if (_startTime == default)
    {
      throw new InvalidOperationException("You can't stop the stopwatch while it's not running!");
    }

    Duration = DateTime.Now - _startTime;
    _startTime = default;
  }

}
