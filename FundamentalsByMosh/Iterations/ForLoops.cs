namespace FundamentalsByMosh.Iterations
{
  public class ForLoops
  {
    public static void Run()
    {
      for (var i = 1; i <= 10; i++)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine(i);
        }
      }

      for (var i = 10; i >= 1; i--)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine(i);
        }
      }
    }

  }
}