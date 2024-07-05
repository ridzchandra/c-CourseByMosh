namespace FundamentalsByMosh.Iterations
{
  public class ForEachLoops
  {
    public static void Run()
    {
      var name = "John Smith";
      // for (var i = 0; i < name.Length; i++)
      // {
      //   Console.WriteLine(name[i]);
      // }

      foreach (var character in name)
      {
        Console.WriteLine(character);
      }

      var numbers = new int[] { 1, 2, 3, 4 };
      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }
    }
  }
}