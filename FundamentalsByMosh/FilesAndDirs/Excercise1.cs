
namespace FundamentalsByMosh.FilesAndDirs;
public class Excercise1
{
  public static void Run()
  {
    var path = "FilesAndDirs/Example.txt";
    var content = File.ReadAllText(path);
    var words = content.Split(' ');
    var trimmedWords = new List<string>();
    Console.WriteLine("The words are:");
    foreach (var word in words)
    {
      var trimmedWord = word.Trim(['\n', '.']);
      trimmedWords.Add(trimmedWord);
      Console.WriteLine(trimmedWord);
    }
    Console.WriteLine("Number of words in Example.txt: " + words.Length);
  }
}
