namespace AdvancedByMosh.ExceptionHandling;

public class Program
{
  public static void Main(string[] args)
  {
    // UseCalculator();
    UseYoutubeApi();
  }

  public static void UseYoutubeApi()
  {
    try
    {
      var service = new YoutubeApi();
      var videos = service.GetVideos("mosh");
    }
    catch (YoutubeException ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
  public static void UseCalculator()
  {
    try
    {
      var calculator = new Calculator();
      var result = calculator.Divide(5, 0);
    }
    catch (DivideByZeroException ex)
    {
      Console.WriteLine("You cannot divide by zero.");
    }
    catch (ArithmeticException ex)
    {
      Console.WriteLine("An unexpected error occurred.");
    }
    catch (Exception ex)
    {
      Console.WriteLine("An unexpected error occurred.");
    }
    finally
    {
      Console.WriteLine("Finally block is always executed.");
      // Useful for releasing resources that implent IDisposable like closing a file or a database connection by calling the Dispose method.
      // ex: streamReader.Dispose();
      // We need to explicitly dispose these resources because they are not managed by the CLR and hence they won't be garbage collected.
      // If we don't dispose these resources, they will be kept open and we will run out of resources, like keeping too many files open or network connections open or database connections open.
    }
  }
}
