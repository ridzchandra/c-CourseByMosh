namespace FundamentalsByMosh.Conditionals
{
  public class Excercise2
  {
    public static void Run()
    {
      Console.WriteLine("Please enter number 1:/n");
      var input1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Please enter number 2:/n");
      var input2 = Convert.ToInt32(Console.ReadLine());


      Console.WriteLine(input1 > input2 ? input1 : input2);

    }
  }
}