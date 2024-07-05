namespace FundamentalsByMosh.Iterations;

public class Excercise4
{
  public static void Run()
  {
    var rand = new Random();
    var chosenNumber = rand.Next(1, 10);
    const int NumberOfChances = 4;
    var hasWon = false;

    for (var i = 0; i < NumberOfChances; i++)
    {
      Console.WriteLine("Guess the number:");
      var input = Convert.ToInt32(Console.ReadLine());

      if (input == chosenNumber)
      {
        hasWon = true;
        break;
      }
      else
      {
        continue;
      }
    }

    Console.WriteLine(hasWon ? "You won!" : $"You lost. The chosen number is {chosenNumber}");
  }
}
