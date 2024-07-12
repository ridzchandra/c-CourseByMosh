using System.Collections;

namespace IntermediateByMosh.Inheritance.Excercises;

public class Stack
{
  private ArrayList ListOfObjects { get; } = new ArrayList();
  public void Push(object obj)
  {
    if (obj == null)
    {
      throw new InvalidOperationException("You can't push 'null' onto the stack!");
    }
    ListOfObjects.Add(obj);
  }

  public object Pop()
  {
    if (ListOfObjects.Count == 0)
    {
      throw new InvalidOperationException("You can't pop from an empty stack!");
    }

    var lastIndex = ListOfObjects.Count - 1;
    var lastObject = ListOfObjects[lastIndex];
    ListOfObjects.RemoveAt(lastIndex);

    return lastObject;
  }

  public void Clear()
  {
    ListOfObjects.Clear();
  }
}
