namespace IntermediateByMosh.Classes;

public class OutModifierUsecaseInDotnet
{
  public static void Run()
  {
    // Using Parse throws an exception which needs to be caught - I prefer this method
    try
    {
      var number = int.Parse("abc");
    }
    catch (Exception)
    {
      Console.WriteLine("Conversion failed");
    }

    // Using TryParse does not throw an exception
    int number2;
    var result = int.TryParse("abc", out number2);
    if (result)
    {
      Console.WriteLine(number2);
    }
    else
    {
      Console.WriteLine("Conversion failed");
    }

  }
}
