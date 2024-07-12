namespace AdvancedByMosh.EventsAndDelegates;
public class Program
{
  public static void Main1(string[] args)
  {
    var video = new Video { Title = "Video 1" };
    var videoEncoder = new VideoEncoder(); // Publisher
    var mailService = new MailService(); // Subscriber
    var messageService = new MessageService(); // Subscriber

    // Subscribers subscribing to the event of the publisher
    videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
    videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

    videoEncoder.Encode(video);
  }
}
