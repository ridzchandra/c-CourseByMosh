namespace IntermediateByMosh.Classes;

public class Point
{
  public int X;
  public int Y;

  public Point(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }

  public void Move(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }

  public void Move(Point newLocation)
  {
    if (newLocation == null)
    {
      throw new ArgumentNullException(nameof(newLocation));
    }


    // this.X = x;
    // this.Y = y;
    // Instead of repeating your code, you can call the other Move method inside this method. This is similar to ":this()" in constructors. However, we need to call it like this for methods.
    Move(newLocation.X, newLocation.Y);
  }

  public static void Run()
  {
    var point = new Point(10, 20);
    point.Move(new Point(40, 60));
    Console.WriteLine($"Point is at {point.X}, {point.Y}");

    point.Move(100, 200);
    Console.WriteLine($"Point is at {point.X}, {point.Y}");
  }

}
