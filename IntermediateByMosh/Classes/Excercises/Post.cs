namespace IntermediateByMosh.Classes.Excercises;

public class Post
{
  public string Title { get; private set; }
  public string Description { get; private set; }
  public DateTime CreatedAt { get; } = DateTime.Now;
  public int VoteCount { get; private set; }

  public Post(string title, string description)
  {
    Title = title;
    Description = description;
  }

  public void UpVote()
  {
    VoteCount++;
  }
  public void DownVote()
  {
    VoteCount--;
  }

}
