using System.Globalization;

namespace FundamentalsByMosh.Strings;

public class Excercise3
{
  public static bool CheckIfValidTime(string timeString)
  {
    if (string.IsNullOrWhiteSpace(timeString))
    {
      return false;
    }

    try
    {
      DateTime.ParseExact(timeString, "HH:mm", CultureInfo.CurrentCulture);
      return true;
    }
    catch (FormatException)
    {
      return false;
    }
  }

  public static void Run()
  {
    Console.WriteLine("Please enter a valid time in 24-hour format:");
    var input = Console.ReadLine();
    var isValid = CheckIfValidTime(input);

    Console.WriteLine(isValid ? "OK" : "Invalid Time");
  }
}
