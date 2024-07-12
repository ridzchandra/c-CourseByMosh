namespace IntermediateByMosh.Inheritance.Excercises;
public class Program
{
  public static void Main1()
  {
    var stack = new Stack();
    stack.Push(1);
    stack.Push("name");
    stack.Push(true);
    // stack.Push(null); // This will throw an InvalidOperationException

    Console.WriteLine(stack.Pop()); // true
    Console.WriteLine(stack.Pop()); // "name"

    stack.Clear();
    // Console.WriteLine(stack.Pop()); // This will throw an InvalidOperationException
  }
}
