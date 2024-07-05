namespace FundamentalsByMosh.Iterations;

public class Excercise3
{
  public static void Run()
  {
    Console.Write("Please enter a number for which you'd like to calculate the factorial: ");
    var input = Convert.ToInt32(Console.ReadLine());

    var factorial = 1;
    for (var i = input; i > 1; i--)
    {
      factorial *= i;
    }

    Console.WriteLine($"{input}! = {factorial}");
  }

}
