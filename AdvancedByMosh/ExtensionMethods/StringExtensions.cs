namespace AdvancedByMosh.ExtensionMethods;

// To create an extension method, we need to create a static class
// Naming convention: <ClassNameYouAreExtending>Extensions
public static class StringExtensions
{
  // Also, the extension method should be static
  // The first parameter of an extension method specifies the type that the method operates on
  // The parameter is preceded by the this keyword 
  public static string Shorten(this string str, int numberOfWords)
  {
    ArgumentOutOfRangeException.ThrowIfNegative(numberOfWords, nameof(numberOfWords));

    if (numberOfWords == 0)
      return "";

    var words = str.Split(' ');
    if (words.Length <= numberOfWords)
      return str;

    // Interesting fact: Array doesn't have a Take method. Take is an extension method which was later added to IEnumerable<T> interface.
    return string.Join(" ", words.Take(numberOfWords)) + "...";
  }
}
