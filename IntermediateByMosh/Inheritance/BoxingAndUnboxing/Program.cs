using System.Collections;

namespace IntermediateByMosh.Inheritance.BoxingAndUnboxing;

public class Program
{
  public static void Main1()
  {
    var list = new ArrayList(); // ArrayList is a non-generic collection that can store any type of object.
    list.Add(1); // Boxing - Converting a value type to an object. This involves a performance penalty because the CLR has to allocate memory on the heap to store the value type.
    list.Add("Mosh"); // Boxing - Converting a value type to an object.
    list.Add(DateTime.Today); // Boxing - Converting a value type to an object.

    var number = (int)list[1]; // Unboxing - Converting an object to a value type. This will throw an InvalidCastException at runtime because the object at index 1 is a string and not an integer.

    // Which is wy we should use generic collections like List<T> instead of non-generic collections like ArrayList.
    var anotherList = new List<int>();
    anotherList.Add(1);
    // anotherList.Add("Mosh"); // This will throw a compile-time error because List<int> is a generic collection that can only store integers.

    Console.WriteLine(number);
  }
}
