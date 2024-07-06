using System.Collections.Frozen;

namespace FundamentalsByMosh.Strings;

public class Excercise2
{
  public static bool CheckIfHasDuplicates(string hyphenSeperatedNumbers)
  {
    var numbers = Array.ConvertAll(hyphenSeperatedNumbers.Split("-"), Convert.ToInt32);
    var numbersSet = numbers.ToFrozenSet();
    return numbers.Length != numbersSet.Count;
  }

  public static void Run()
  {
    Console.WriteLine("Please enter hyphen separated numbers:");
    var input = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(input))
    {
      var hasDuplicates = CheckIfHasDuplicates(input);
      Console.WriteLine(hasDuplicates ? "Has duplicates" : "No duplicates");
    }
  }

}
