namespace IntermediateByMosh.Classes.Excercises;
public class Program
{
  public static void Main2()
  {
    // UseStopwatch();
    UsePost();

  }

  public static void UsePost()
  {
    var post = new Post("Post1", "This is the first post on StackOverflow.");
    post.UpVote();
    post.UpVote();
    post.UpVote();
    post.DownVote();
    post.UpVote();
    Console.WriteLine(@$"Title: {post.Title}
Description: {post.Description}
Posted At: {post.CreatedAt}
Number of Votes: {post.VoteCount}");
  }


  public static void UseStopwatch()
  {
    Stopwatch.Start();
    Thread.Sleep(4000); // just for setting a timeout
    Stopwatch.Stop();
    Console.WriteLine(Stopwatch.Duration);

    Stopwatch.Start();
    Thread.Sleep(4000); // just for setting a timeout
    Stopwatch.Stop();
    Console.WriteLine(Stopwatch.Duration);

    // Stopwatch.Start();
    // Stopwatch.Start(); // throws an exception
    // Console.WriteLine(Stopwatch.Duration);
  }
}
