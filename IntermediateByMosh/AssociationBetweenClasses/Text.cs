namespace IntermediateByMosh.AssociationBetweenClasses;

// In c#, a class can inherit from only one class.
public class Text : PresentationObject
{
  public int FontSize { get; set; }
  public string FontName { get; set; }

  public void AddHyperlink(string url)
  {
    Console.WriteLine("Added a link to " + url);
  }
}
