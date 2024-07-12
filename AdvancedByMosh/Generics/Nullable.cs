namespace AdvancedByMosh.Generics;

// where T : struct is a constraint to limit the type of T to value types
public class Nullable<T> where T : struct
{
  // In c# value types cannot be null, so we use object to store the value i.e, boxing
  private object _value;

  // In real world apps, we don't need to implement this class as it is already implemented in the System namespace which is System.Nullable<T>
  // We'll look at it later.
  public Nullable()
  {
  }

  public Nullable(T value)
  {
    _value = value;
  }

  public bool HasValue
  {
    get { return _value != null; }
  }

  public T GetValueOrDefault()
  {
    if (HasValue)
      // Unboxing
      return (T)_value;

    return default;
  }
}
