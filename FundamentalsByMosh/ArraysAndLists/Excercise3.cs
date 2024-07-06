namespace FundamentalsByMosh.ArraysAndLists;

public class Excercise3
{
  public static void Run()
  {
    var numbers = new List<int>();
    for (var i = 1; i <= 5; i++)
    {
      if (i == 1)
      {
        Console.WriteLine("Please enter 5 unique numbers one by one:");
      }
      else
      {
        Console.WriteLine("Please enter the number:");
      }

      var input = Convert.ToInt32(Console.ReadLine());
      if (numbers.Contains(input))
      {
        Console.WriteLine("You've already entered this number earlier! Please retry.");
        i--;
        continue;
      }
      else
      {
        numbers.Add(input);
      }
    }

    numbers.Sort();
    Console.WriteLine($"Here are the numbers you've entered: {string.Join(", ", numbers)}");
  }
}
