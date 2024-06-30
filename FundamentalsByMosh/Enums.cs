namespace FundamentalsByMosh
{
  // Remember that since enum is a new type, it should be defined at the namespace level
  // If you don't assign values to the enum members, they will be assigned values starting from 0
  // But it's a good practice to assign values explicitly to avoid them changing when you add new members in the future.
  public enum ShippingMethod
  {
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
  }
  class Enums
  {
    static void Main9(string[] args)
    {
      var method = ShippingMethod.Express;
      Console.WriteLine((int)method); // 3

      var methodId = 3;
      Console.WriteLine((ShippingMethod)methodId); // Express

      // Console.WriteLine automatically calls ToString() method on the object passed to it. So, you can skip calling ToString() explicitly inside Console.WriteLine
      Console.WriteLine(method.ToString()); // Express

      var methodName = "Express";
      var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

      Console.WriteLine(shippingMethod); // Express
      Console.WriteLine((int)shippingMethod); // 3
    }
  }
}
