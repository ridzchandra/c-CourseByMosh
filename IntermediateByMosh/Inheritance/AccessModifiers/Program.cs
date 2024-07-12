using Amazon;

namespace IntermediateByMosh.Inheritance.AccessModifiers;

public class Program
{
  static void Main1(string[] args)
  {
    var customer = new AmazonCustomer();
    customer.Promote();
  }
}

