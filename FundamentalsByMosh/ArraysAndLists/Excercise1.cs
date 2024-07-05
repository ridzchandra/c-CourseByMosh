namespace FundamentalsByMosh.ArraysAndLists;

public class Excercise1
{
  public static void Run()
  {
    var NamesList = new List<string>();
    while (true)
    {
      Console.WriteLine("Please enter the name of a person that liked your post:");
      var input = Console.ReadLine();
      if (string.IsNullOrWhiteSpace(input))
      {
        break;
      }
      NamesList.Add(input);
    }

    if (NamesList.Count == 1)
    {
      Console.WriteLine($"{NamesList[0]} likes your post.");
    }
    else if (NamesList.Count == 2)
    {
      Console.WriteLine($"{NamesList[0]} and {NamesList[1]} like your post.");
    }
    else if (NamesList.Count > 2)
    {
      Console.WriteLine($"{NamesList[0]}, {NamesList[1]} and {NamesList.Count - 2} others like your post.");
    }
  }
}
