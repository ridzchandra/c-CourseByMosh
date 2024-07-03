using System.Diagnostics;

namespace FundamentalsByMosh.Conditionals
{
  public class Excercise4
  {
    const int DemeritPointsPer5KMPH = 1;
    const int MaxDemeritPointsPerPerson = 12;

    public static void Run()
    {
      Console.WriteLine("What's the speed limit on this road?/n");
      var speedLimit = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("What's your current speed?/n");
      var currentSpeed = Convert.ToInt32(Console.ReadLine());

      if (currentSpeed <= speedLimit)
      {
        Console.WriteLine("OK");
      }
      else
      {
        var demeritPoints = (currentSpeed - speedLimit) / 5;
        Console.WriteLine($"You've incurred {demeritPoints} demerit points.");
        if (demeritPoints > MaxDemeritPointsPerPerson)
        {
          Console.WriteLine("Your license has been suspended!");
        }
      }
    }
  }
}