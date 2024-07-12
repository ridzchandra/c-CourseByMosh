namespace AdvancedByMosh.Generics;

public class Utilities
{
  public int Max(int a, int b)
  {
    return a > b ? a : b;
  }

  // 'where' is a constraint to limit the type of T to IComparable
  // without this constraint, we can't use CompareTo method on T because it's not defined in the object class
  // You can move the constraint to the class level if you want to use it in multiple methods and just use T without constraints in the method
  public T Max<T>(T a, T b) where T : IComparable
  {
    return a.CompareTo(b) > 0 ? a : b;
  }

  public void DoSomething<T>(T value) where T : IComparable, new()
  {
    var obj = new T();
  }
}
