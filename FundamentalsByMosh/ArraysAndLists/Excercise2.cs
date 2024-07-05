namespace FundamentalsByMosh.ArraysAndLists;

public class Excercise2
{
  public static void Run()
  {
    Console.Write("Please enter your name: ");
    var input = Console.ReadLine();

    var strArray = input.ToCharArray();
    var reverseArray = strArray.Reverse();
    var reverse = new string(reverseArray.ToArray());
    Console.WriteLine(reverse);
  }
}
