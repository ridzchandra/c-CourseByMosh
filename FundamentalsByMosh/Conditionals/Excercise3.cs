namespace FundamentalsByMosh.Conditionals
{
  public class Excercise3
  {
    public static void Run()
    {
      Console.WriteLine("Please enter the height of the image:/n");
      var height = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Please enter the width of the image:/n");
      var width = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"It's a {(height > width ? "portrait" : "landscape")} oriented image.");
    }
  }
}