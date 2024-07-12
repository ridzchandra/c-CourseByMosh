namespace Amazon;
public class AmazonCustomer
{
  public int Id { get; set; }
  public string Name { get; set; }

  public void Promote()
  {
    var rating = CalculateRating(excludeOrders: true);
    if (rating == 0)
      Console.WriteLine("Promoted to Level 1");
    else
      Console.WriteLine("Promoted to Level 2");
  }

  public void Demote()
  {
    // Generally speaking, it's not a good practice to create an instance of a class inside a method here as this creates coupling or dependency to this object. In the interfaces section we'll look at a better way to do this.
    var calculator = new RateCalculator();
    var rating = calculator.Calculate(this);
    if (rating == 0)
      Console.WriteLine("Demoted to Level 1");
    else
      Console.WriteLine("Demoted to Level 2");
  }


  // CalculateRating is the implementation detail of the Customer class. Public interface should just expose the Promote method not what it uses internally to do it's job. The reason for this is if the implementation of CalculateRating changes let's say a new arg added called "excludeOrders", it should not affect the consumers of the Customer class because it's an implementation detail. 
  protected int CalculateRating(bool excludeOrders)
  {
    return 0;
  }
}

