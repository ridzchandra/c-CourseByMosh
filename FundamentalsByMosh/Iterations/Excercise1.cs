namespace FundamentalsByMosh.Iterations;

public class Excercise1
{
  public static void Run()
  {
    var count = 0;
    for (var i = 1; i <= 100; i++)
    {
      if (i % 3 == 0)
      {
        count++;
      }
    }
    Console.WriteLine($"There are {count} numbers between 1 and 100 that are divisible by 3.");
  }

}
