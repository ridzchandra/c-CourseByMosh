namespace FundamentalsByMosh.Strings;

public class Excercise5
{
  public static byte CountVowels(string word)
  {
    byte count = 0;

    foreach (char c in word.ToLower())
    {
      switch (c)
      {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
          count++;
          break;
      }
    }

    return count;
  }
  public static void Run()
  {
    Console.WriteLine("Please enter an English word:");
    var input = Console.ReadLine();
    Console.WriteLine(CountVowels(input));
  }
}
