namespace FundamentalsByMosh.Iterations
{
  public class WhileAndDoWhileLoops
  {
    public static void Run()
    {
      var i = 0;
      while (i <= 10)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine(i);
        }
        i++;
      }

      while (true)
      {
        Console.Write("@while Type your name: ");
        var input = Console.ReadLine();

        if (!String.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("@while Echo: " + input);
          continue;
        }

        break;
      }

      do
      {
        Console.Write("@doWhile Type your name: ");
        var input = Console.ReadLine();

        if (!String.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("@doWhile Echo: " + input);
          continue;
        }

        break;
      } while (true);
    }
  }
}