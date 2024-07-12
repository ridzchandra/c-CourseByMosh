namespace IntermediateByMosh;

public partial class Program
{
  public class Car : Vehicle
  {
    public Car()
    {
      Console.WriteLine("Car is being initialized.");
    }
    public Car(string registrationNumber)
      : base(registrationNumber)
    {
      Console.WriteLine($"Car is being initialized. {registrationNumber}");
    }
  }
}
