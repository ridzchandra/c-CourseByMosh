namespace FundamentalsByMosh.Conditionals
{
  public class Program
  {
    public void Run()
    {
      // If Statement
      int hour = 10;
      if (hour > 0 && hour < 12)
      {
        Console.WriteLine("It's morning.");
      }
      else if (hour >= 12 && hour < 18)
      {
        Console.WriteLine("It's afternoon.");
      }
      else
      {
        Console.WriteLine("It's evening.");
      }

      // Conditional Operator
      bool isGoldCustomer = true;
      float price;
      if (isGoldCustomer)
      {
        price = 19.95f;
      }
      else
      {
        price = 29.95f;
      }
      Console.WriteLine(price); // 19.95

      // Simplified Conditional Operator
      price = (isGoldCustomer) ? 19.95f : 29.95f;
      Console.WriteLine(price); // 19.95

      // Switch Statement
      var season = Season.Autumn;
      switch (season)
      {
        case Season.Spring:
        case Season.Summer:
          Console.WriteLine("We've got a promotion.");
          break;
        case Season.Autumn:
          Console.WriteLine("It's autumn.");
          break;
        case Season.Winter:
          Console.WriteLine("It's winter.");
          break;
        default:
          Console.WriteLine("I don't understand that season.");
          break;
      }
    }
    static void Main11(string[] args)
    {
      var program = new Program();
      // program.Run();

      // Excercise1.Run();
      // Excercise2.Run();
      // Excercise3.Run();
      Excercise4.Run();
    }
  }
}