namespace AdvancedByMosh.Dynamic;

class Program
{
  static void Main1(string[] args)
  {
    // dynamic types are resolved at runtime - similar to 'any' in TypeScript
    dynamic name = "Mosh";
    name = 10;

    dynamic a = 10;
    dynamic b = 5;
    var c = a + b; // c is dynamic

    dynamic e = 10;
    int f = 5;
    var g = e + f; // g is dynamic - dynamic + int = dynamic

    // dynamic types can be implicitly converted to other types - you don't need to cast them explicitly if they are implicitly convertible.
    int i = 5;
    dynamic d = i; // d is dynamic
    long l = d; // l is long
  }
}
