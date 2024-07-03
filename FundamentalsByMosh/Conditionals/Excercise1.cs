namespace FundamentalsByMosh.Conditionals
{
  public class Excercise1
  {
    public static void Run()
    {
      var min = 1;
      var max = 10;

      Console.WriteLine("Please enter a number:/n");
      var input = Convert.ToInt32(Console.ReadLine());

      if (input >= min && input <= max)
      {
        Console.WriteLine("Valid");
      }
      else
      {
        Console.WriteLine("Invalid");
      }
    }
  }
}