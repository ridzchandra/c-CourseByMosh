namespace AdvancedByMosh.EventsAndDelegates;

public class VideoEncoder
{
  // 1. Define a delegate - conventionally has 2 parameters in dotnet, first is the source class object of the event i.e, the publisher, second is any additional data that is sent with the event and should return void.
  // 2. Naming convention for the delegate - <NameOfTheEvent>EventHandler
  // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
  // 3. Define an event based on that delegate
  // public event VideoEncodedEventHandler VideoEncoded;

  // We can merge steps 2 & 3 into a single step as shown below using the built-in EventHandler<T> delegate instead of defining a custom delegate for Event Handling.
  public event EventHandler<VideoEventArgs> VideoEncoded;



  // 4. Define the event publisher method - conventionally named as On<NameOfTheEvent> and is protected, virtual and should return void.
  protected virtual void OnVideoEncoded(Video video)
  {
    // Check if there are any subscribers to the event - if not, the event will be null
    if (VideoEncoded != null)
      VideoEncoded(this, new VideoEventArgs { Video = video });
  }

  public void Encode(Video video)
  {
    Console.WriteLine("Encoding video...");
    Thread.Sleep(3000);

    // 5. Raise(Publish) the event using an event publisher method 
    OnVideoEncoded(video);
  }


}
