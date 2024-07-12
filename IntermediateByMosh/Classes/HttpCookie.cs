namespace IntermediateByMosh.Classes;

public class HttpCookie
{
  // Dictionary type uses hash table to store key-value pairs. If you want to look up a value by key, use Dictionary. If you want to look up a value by index, use List.
  private readonly Dictionary<string, string> _dictionary;

  public DateTime Expiry { get; set; }

  public HttpCookie()
  {
    _dictionary = new Dictionary<string, string>();
  }

  // If you have a class that has the semantic use case of a Dictionary, List or any other collection, along with other properties and methods of its own, you can use the collection type as a field in the class and indexer to expose the class object as a collection.
  public string this[string key]
  {
    get { return _dictionary[key]; }
    set { _dictionary[key] = value; }
  }
}
