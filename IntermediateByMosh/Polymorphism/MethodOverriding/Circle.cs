namespace IntermediateByMosh.Polymorphism.MethodOverriding;

public class Circle : Shape
{
  public override void Draw()
  {
    Console.WriteLine("Draw a circle");
    // We can call the base class method using the base keyword either before or after the derived class specific logic.
    // base.Draw();
  }
}
