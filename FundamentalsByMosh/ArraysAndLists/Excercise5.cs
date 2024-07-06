namespace FundamentalsByMosh.ArraysAndLists;

public class Excercise5
{
  public static void Run()
  {
    while (true)
    {
      Console.WriteLine("Please enter comma seperated numbers: (At least 5)");
      var input = Console.ReadLine();
      if (string.IsNullOrWhiteSpace(input))
      {
        Console.WriteLine("Invalid list! Please retry.");
        continue;
      }

      var numberStrings = input.Split(',');
      var numbers = Array.ConvertAll(numberStrings, Convert.ToInt32);
      if (numbers.Length < 5)
      {
        Console.WriteLine("Invalid list! Please retry.");
        continue;
      }

      Array.Sort(numbers);
      var threeSmallestNumbers = new int[3];
      Array.Copy(numbers, threeSmallestNumbers, 3);

      Console.WriteLine("The three smallest numbers from the ones you've entered are: " + string.Join(", ", threeSmallestNumbers));
      break;
    }
  }
}
