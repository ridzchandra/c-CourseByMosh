namespace AdvancedByMosh.ExtensionMethods;

public class Program
{
  public static void Main1(string[] args)
  {
    string post = "This is supposed to be a very long blog post blah blah blah...";
    // We can call the extension method as if it were an instance method
    // These extension methods only become available after we include the namespace where the extension method is defined using "using" directive.
    // So Mosh prefers to define extension methods in the System namespace as that namespace is already included in every C# file by default.

    // Note: Although we are calling extension methods as if they were instance methods (because of the 'this' parameter in their definition), they are actually static methods.
    // This could cause problems if the creatot of the class we're extending later creates an instance method with the same name and signature that behaves differently.
    // Since instance methods take precedence over extension methods, the instance method would be called instead of the extension method.
    // So if possible, try to derive from the class rather than using extension methods or directly modify the source class if you have access to it.
    // Use extension methods sparingly and only when you can't modify the source code or derive from the class because they are sealed.
    var shortenedPost = post.Shorten(5);
    Console.WriteLine(shortenedPost);

    // More commonly we consume extension methods from other libraries rather than creating them ourselves.
    // For example, the LINQ library has a lot of extension methods that we use in our code.
    IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    var max = numbers.Max();
    Console.WriteLine(max);
  }

}
