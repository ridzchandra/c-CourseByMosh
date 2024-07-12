namespace AdvancedByMosh.Generics;
// where TProduct : Product is a constraint to limit the type of TProduct to Product or its subclasses
public class DiscountCalculator<TProduct> where TProduct : Product
{
  public float CalculateDiscount(TProduct product)
  {
    return product.Price;
  }
}
