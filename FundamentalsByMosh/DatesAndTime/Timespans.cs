namespace FundamentalsByMosh.DatesAndTime
{
  public class Timespans
  {
    public static void Run()
    {
      // TimeSpan
      var timeSpan = new TimeSpan(1, 2, 3);
      var timeSpan1 = new TimeSpan(1, 0, 0);
      var timeSpan2 = TimeSpan.FromHours(1);

      var start = DateTime.Now;
      var end = DateTime.Now.AddMinutes(2);
      var duration = end - start;

      Console.WriteLine("Duration: " + duration);

      // Properties
      Console.WriteLine("Minutes: " + timeSpan.Minutes); // 2
      Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // 62.05

      // Add
      Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
      Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

      // ToString
      Console.WriteLine("ToString: " + timeSpan.ToString());

      // Parse
      Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
    }
  }
};


