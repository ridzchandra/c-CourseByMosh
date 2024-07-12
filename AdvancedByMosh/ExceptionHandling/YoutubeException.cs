namespace AdvancedByMosh.ExceptionHandling;

public class YoutubeException : Exception
{
  public YoutubeException(string message, Exception innerException)
    : base(message, innerException)
  {
  }
}
