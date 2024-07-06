namespace FundamentalsByMosh.Strings;

public class Excercise4
{
  public static string PascalCase(string text)
  {
    var words = text.Split(' ');
    var capitaliseWords = new List<string>();
    foreach (var word in words)
    {
      var firstLetter = word[0];
      var restOfTheWord = word.Substring(1);
      var capitalisedWord = char.ToUpper(firstLetter) + restOfTheWord.ToLower();
      capitaliseWords.Add(capitalisedWord);
    }

    return string.Join("", capitaliseWords);
  }

  public static void Run()
  {
    Console.WriteLine("Please enter a few words separated by spaces:");
    var input = Console.ReadLine();
    Console.WriteLine(PascalCase(input));
  }
}
