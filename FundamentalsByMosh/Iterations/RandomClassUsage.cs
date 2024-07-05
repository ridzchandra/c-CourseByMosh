namespace FundamentalsByMosh;

public class RandomClassUsage
{
  public static void Run()
  {
    var random = new Random();
    for (var i = 0; i < 10; i++)
    {
      Console.WriteLine(random.Next());
    }

    for (var i = 0; i < 10; i++)
    {
      Console.WriteLine(random.Next(1, 10));
    }

    var passwordLength = 10;
    var passwordBuffer = new char[passwordLength];
    for (var i = 0; i < passwordLength; i++)
    {
      passwordBuffer[i] = (char)('a' + random.Next(0, 26));
    }
    var generatedPassword = new string(passwordBuffer);
    Console.WriteLine(generatedPassword);
  }
}
