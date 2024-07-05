namespace FundamentalsByMosh.DatesAndTime
{
  public class DateAndTime
  {
    public static void Run()
    {
      var dateTime = new DateTime(2021, 1, 1);
      var now = DateTime.Now;
      var today = DateTime.Today;

      Console.WriteLine(now);
      Console.WriteLine("Hour: " + now.Hour);
      Console.WriteLine("Minute: " + now.Minute);
      Console.WriteLine(today);

      // DateTime objects are immutable. The methods return a new DateTime object.
      var tomorrow = now.AddDays(1);
      var yesterday = now.AddDays(-1);

      Console.WriteLine(now.ToLongDateString());
      Console.WriteLine(now.ToShortDateString());
      Console.WriteLine(now.ToLongTimeString());
      Console.WriteLine(now.ToShortTimeString());

      // Using format specifiers with ToString
      Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));
    }

  }
};


