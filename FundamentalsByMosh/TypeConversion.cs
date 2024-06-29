namespace TypeConversion
{
  class Program
  {
    static void Main3(string[] args)
    {
      // Implicit Type Conversion:
      // byte > short > int > long > float > double
      byte b = 1;
      int i = b;
      Console.WriteLine(i);

      int i2 = 1;
      // byte b2 = i2; // This will give an error because you cannot implicitly convert a larger type to a smaller type.
      byte b2 = (byte)i2; // This is called explicit type conversion or casting.
      Console.WriteLine(b2);

      // Non-compatible types:
      string s = "1";
      // int i3 = (int)s; // This will give an error because you cannot convert a string to an integer.
      int i3 = Convert.ToInt32(s);
      Console.WriteLine(i3);

      // Handling exceptions:
      // Whenever you're dealing with non-compatible types, there's a chance of an exception being thrown. You should always handle these exceptions.
      try
      {
        var number = "1234";
        byte b3 = Convert.ToByte(number);
        Console.WriteLine(b3);
      }
      catch (Exception)
      {
        Console.WriteLine("The number could not be converted to a byte.");
      }

      try
      {
        string str = "true";
        bool b4 = Convert.ToBoolean(str);
        Console.WriteLine(b4);
      }
      catch (Exception)
      {
        Console.WriteLine("The string could not be converted to a boolean.");
      }
    }
  }
}