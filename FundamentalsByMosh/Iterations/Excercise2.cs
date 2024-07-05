namespace FundamentalsByMosh.Iterations;

public class Excercise2
{
  public static void Run()
  {
    var sum = 0;
    while (true)
    {
      Console.WriteLine("Please enter a number or 'ok' to exit.");
      var input = Console.ReadLine();
      if (input == "ok")
      {
        break;
      }
      sum += Convert.ToInt32(input);
    }

    Console.WriteLine($"The sum of the numbers entered so far is {sum}");
  }
}
