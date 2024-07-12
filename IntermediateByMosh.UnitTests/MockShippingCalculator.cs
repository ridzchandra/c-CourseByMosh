using IntermediateByMosh.Interfaces.Testability;

namespace IntermediateByMosh.UnitTests;

public class MockShippingCalculator : IShippingCalculator
{
  // Any methods that are declared in an interface must be implemented in the class that implements the interface. Also they have to be public because the interface declares what the public interface of an implementing class should look like.
  public float CalculateShipping(Order order)
  {
    return 1;
  }
}