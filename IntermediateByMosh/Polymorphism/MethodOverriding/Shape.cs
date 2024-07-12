namespace IntermediateByMosh.Polymorphism.MethodOverriding;

public abstract class Shape
{
  public int Width { get; set; }
  public int Height { get; set; }

  public abstract void Draw();

  // An abstract class, unlike an Interface can still provide implementation for some of the methods. This is useful when we have a common implementation for all the derived classes.
  public virtual void CopyWidth()
  {
    Console.WriteLine("Copy shape width into clipboard:" + Width);
  }
}
