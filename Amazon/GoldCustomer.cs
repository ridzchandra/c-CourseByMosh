namespace Amazon;

public class GoldCustomer : AmazonCustomer
{
  public void OfferVoucher()
  {
    // We can access CalculateRating because it's protected and GoldCustomer is a derived class of Customer class.
    var rating = CalculateRating(excludeOrders: true);
  }
}

