namespace Amazon;

// RateCalculator is a helper class that is used by the AmazonCustomer class to calculate the rating of a customer. This class is not exposed to the outside world. It's an implementation detail of the AmazonCustomer class. Hence this internal class is not accessible on Amazon namespace outside this Amazon project.
internal class RateCalculator
{
  public int Calculate(AmazonCustomer customer)
  {
    return 0;
  }
}

