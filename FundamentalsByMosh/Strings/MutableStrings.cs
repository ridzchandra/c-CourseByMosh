using System.Text;

namespace FundamentalsByMosh.Strings;

public class MutableStrings
{
  public static void Run()
  {
    // String Builder
    // StringBuilder is a mutable string
    // It is more efficient than using the `+` operator to concatenate strings
    // because it does not create a new string object every time you append a string
    // It is useful when you need to concatenate a large number of strings
    var builder = new StringBuilder();
    builder.Append('-', 10); // ----------
    builder.AppendLine();
    builder.Append("Header");
    builder.AppendLine();
    builder.Append('-', 10);
    builder.Replace('-', '+'); // ++++++++++Header\n++++++++++
    builder.Insert(0, new string('-', 10)); // ----------++++++++++Header\n++++++++++
    Console.WriteLine(builder);

    // Indexer
    Console.WriteLine("First Char: " + builder[0]); // -

    // Mutable Strings
    // Strings are immutable in C#
    // This means that once you create a string object, you cannot change its value
    // If you want to modify a string, you need to create a new string object
    // This can be inefficient when you need to modify a string multiple times
    // In such cases, you can use the StringBuilder class
    string name = "John";
    name += " Smith";
    name += " Jr.";
    Console.WriteLine(name); // John Smith Jr.

    // String Builder Methods
    // All StringBuilder methods return a reference to the StringBuilder object
    // This allows you to chain multiple methods together
    var sb = new StringBuilder("Hello World");
    sb
      .Append('!', 3)
      .AppendLine()
      .Append("C# is awesome")
      .AppendLine()
      .Append('-', 10);
    Console.WriteLine(sb); // Hello World!!!\nC# is awesome\n----------

    // String Builder Methods
    var sb2 = new StringBuilder("Hello World");
    sb2.Insert(5, "C# "); // Hello C# World
    sb2.Remove(5, 3); // Hello World
    sb2.Replace("World", "C#");
    Console.WriteLine(sb2); // Hello C#!
  }
}
