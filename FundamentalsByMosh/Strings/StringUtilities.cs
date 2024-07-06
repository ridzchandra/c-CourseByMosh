namespace FundamentalsByMosh.Strings;

public class StringUtilities
{
  public static string SummarizeText(string text, int maxLength = 20)
  {
    if (text.Length <= 20)
    {
      return text;
    }

    var words = text.Split(" ");
    var totalCharacters = 0;
    var wordList = new List<string>();
    foreach (var word in words)
    {
      totalCharacters += word.Length + 1; // +1 for space after each word in the text
      if (totalCharacters > maxLength)
      {
        break;
      }
      wordList.Add(word);
    }

    return String.Join(" ", wordList) + "...";
  }
}
