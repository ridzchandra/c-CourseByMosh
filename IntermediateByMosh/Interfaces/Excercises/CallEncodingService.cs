namespace IntermediateByMosh.Interfaces.Excercises;

public class CallEncodingService : IActivity
{
  public void Execute()
  {
    Console.WriteLine("Calling third party video encoding service...");
  }
}
