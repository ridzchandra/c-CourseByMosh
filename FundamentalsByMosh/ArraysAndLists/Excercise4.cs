using System.Collections.Frozen;

namespace FundamentalsByMosh.ArraysAndLists;

public class Excercise4
{
  public static void Run()
  {
    var numbers = new List<int>();
    while (true)
    {
      Console.WriteLine("Please enter a number: (Type 'Quit' to exit)");
      var input = Console.ReadLine();
      if (input == "Quit")
      {
        break;
      }
      var number = Convert.ToInt32(input);
      numbers.Add(number);
    }

    Console.WriteLine($"Here are the distinct numbers you've entered: {string.Join(", ", numbers.ToFrozenSet())}");
  }
}
