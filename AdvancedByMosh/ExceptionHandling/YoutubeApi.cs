namespace AdvancedByMosh.ExceptionHandling;

public class YoutubeApi
{
  public List<Video> GetVideos(string user)
  {
    try
    {
      // Access Youtube web service
      // Read the data
      // Create a list of Video objects

      // This will be set as the inner exception in the YoutubeException in the catch block
      throw new Exception("Oops some low level Youtube error.");
    }
    catch (Exception ex)
    {
      // Log
      // Showing how to use custom exceptions
      throw new YoutubeException("Could not fetch the videos from Youtube.", ex);
    }

    return new List<Video>();
  }
}
