namespace IntermediateByMosh.Interfaces.Polymorphism;

public class Program
{
  public static void Main1()
  {
    var encoder = new VideoEncoder();
    encoder.RegisterNotificationChannel(new MailNotificationChannel());
    encoder.RegisterNotificationChannel(new SmsNotificationChannel());
    encoder.Encode(new Video());
  }
}

