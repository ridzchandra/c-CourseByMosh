
namespace FundamentalsByMosh.FilesAndDirs;

public class Excercise2
{
  public static void Run()
  {
    var path = "FilesAndDirs/Example.txt";
    var content = File.ReadAllText(path);
    var words = content.Split(' ');
    var trimmedWords = new List<string>();
    var longestWord = words[0];
    Console.WriteLine("The words are:");
    foreach (var word in words)
    {
      var trimmedWord = word.Trim(['\n', '.']);
      trimmedWords.Add(trimmedWord);
      Console.WriteLine(trimmedWord);

      if (trimmedWord.Length > longestWord.Length)
      {
        longestWord = trimmedWord;
      }
    }
    Console.WriteLine("Longest word in Example.txt: " + longestWord);

  }
}
