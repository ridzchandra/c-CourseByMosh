using System;

namespace FundamentalsByMosh.Iterations;

public class Excercise5
{
  public static void Run()
  {
    Console.WriteLine("Please enter a series of comma seperated numbers:");
    var input = Console.ReadLine();
    var numbers = input.Split(',');
    var max = numbers.Max();

    Console.WriteLine($"Max number: {max}");
  }
}
