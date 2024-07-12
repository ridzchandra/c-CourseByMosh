namespace IntermediateByMosh.Inheritance.UpcastAndDowncast;
public class Program
{
  public static void Main1(string[] args)
  {
    Text text = new Text();
    Shape shape = text; // Upcasting (implicit) - shape is a reference to the same object as text. It just has a different view of the object i.e, only the members of the base class are accessible on the shape reference at the compile time although the actual object during the runtime has all the members of the derived class.

    text.Width = 200;
    shape.Width = 100;

    Shape shape1 = new Text();
    Text text1 = (Text)shape1; // Downcasting (explicit) - shape1 is a reference to the same object as text1. It just has a different view of the object i.e, all the members of the derived class are accessible on the text1 reference at the compile time.


    Console.WriteLine(text.Width); // 100
  }

}
