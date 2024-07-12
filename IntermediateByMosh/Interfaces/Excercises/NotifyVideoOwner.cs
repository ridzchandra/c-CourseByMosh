namespace IntermediateByMosh.Interfaces.Excercises;

public class NotifyVideoOwner : IActivity
{
  public void Execute()
  {
    Console.WriteLine("Sending an email to the video owner that the video processing has started...");
  }
}
