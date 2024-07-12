namespace IntermediateByMosh.Interfaces.Polymorphism;

public class VideoEncoder
{
  private readonly IList<INotificationChannel> _notificationChannels;

  public VideoEncoder()
  {
    _notificationChannels = new List<INotificationChannel>();
  }

  public void RegisterNotificationChannel(INotificationChannel channel)
  {
    _notificationChannels.Add(channel);
  }

  public void Encode(Video video)
  {
    // Video encoding logic...

    // Send notification to all registered channels upon completion
    foreach (var channel in _notificationChannels)
    {
      channel.Send(new Message());
    }
  }
}

