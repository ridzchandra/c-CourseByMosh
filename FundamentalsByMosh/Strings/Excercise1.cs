namespace FundamentalsByMosh;

public class Excercise1
{
  public static bool CheckIfConsecutive(string hyphenSeperatedNumbers)
  {
    var numbers = Array.ConvertAll(hyphenSeperatedNumbers.Split("-"), Convert.ToInt32);
    for (int i = 1; i < numbers.Length; i++)
    {
      var difference = numbers[i] - numbers[i - 1];
      if (difference != 1 && difference != -1)
      {
        return false;
      }
    }
    return true;
  }

  public static void Run()
  {
    Console.WriteLine("Please enter hyphen seperated numbers:");
    var input = Console.ReadLine();
    var areConsecutive = CheckIfConsecutive(input);

    Console.WriteLine(areConsecutive ? "Consecutive" : "Not consecutive");
  }
}
