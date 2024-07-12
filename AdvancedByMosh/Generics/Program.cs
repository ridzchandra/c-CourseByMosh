namespace AdvancedByMosh.Generics;
public class Program
{

  // All the available constraints are:
  // where T : IComparable which means T is IComparable
  // where T : Product which means T is Product or its subclasses
  // where T : struct which means T is a value type
  // where T : class which means T is a reference type
  // where T : new() which means T has a default constructor
  // where T : <base class> which means T is a subclass of <base class>
  // where T : U which means T is U or its subclasses
  // where T : U, new() which means T is U or its subclasses and has a default constructor
  // where T : U, V which means T is U or its subclasses and implements V
  // where T : U, V, new() which means T is U or its subclasses, implements V and has a default constructor

  public static void Main1()
  {
    var book = new Book { Isbn = "1111", Title = "C# Advanced" };
    var numbers = new GenericList<int>();
    numbers.Add(10);
    var dictionary = new GenericDictionary<string, Book>();
    dictionary.Add("1234", new Book());

    var nullable = new Nullable<int>();
    Console.WriteLine("Has Value? " + nullable.HasValue);
    Console.WriteLine("Value: " + nullable.GetValueOrDefault());

    var number = new Nullable<int>(5);
    Console.WriteLine("Has Value? " + number.HasValue);
    Console.WriteLine("Value: " + number.GetValueOrDefault());
  }
}
