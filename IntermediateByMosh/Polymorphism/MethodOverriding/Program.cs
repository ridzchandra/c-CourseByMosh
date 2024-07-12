namespace IntermediateByMosh.Polymorphism.MethodOverriding;

public class Program
{
  public static void Main1()
  {
    var shapes = new List<Shape>
    {
      new Circle(),
      new Rectangle()
    };

    foreach (var shape in shapes)
    {
      // Even though we are iterating through a list of shapes, at the runtime, the Draw method of the derived class will be called. This is called polymorphism.
      shape.Draw();
    }
  }
}
