namespace Operators
{
  class Program
  {
    static void Main4(string[] args)
    {
      // Arithmetic Operators:
      int a = 10;
      int b = 3;
      Console.WriteLine(a + b); // 13
      Console.WriteLine(a - b); // 7
      Console.WriteLine(a * b); // 30
      Console.WriteLine(a / b); // 3 because both are integers, so the result will be an integer.
      Console.WriteLine((float) a / b); // 3.333333 because we casted a to a float. We just need to cast one of the operands to a float to get a float result.
      Console.WriteLine(a % b); // 1

      // Comparison Operators:
      Console.WriteLine(a > b);
      Console.WriteLine(a >= b);
      Console.WriteLine(a < b);
      Console.WriteLine(a <= b);
      Console.WriteLine(a == b);
      Console.WriteLine(a != b);

      // Logical Operators:
      Console.WriteLine(a > 5 && b > 5);
      Console.WriteLine(a > 5 && b < 5);
      Console.WriteLine(a > 5 || b < 5);
      Console.WriteLine(!(a > 5 || b < 5));

      // Bitwise Operators:
      Console.WriteLine(a | b);
      Console.WriteLine(a & b);

      // Assignment Operators:
      a += 3;
      Console.WriteLine(a);
      a -= 3;
      Console.WriteLine(a);
      a *= 3;
      Console.WriteLine(a);
      a /= 3;
      Console.WriteLine(a);
      a %= 3;
      Console.WriteLine(a);

      // Conditional Operators:
      int c = 10;
      int d = 3;
      int max = (a > b) ? a : b;
      Console.WriteLine(max);

      // Type Operators:
      int number = 10;
      bool isNumber10 = number == 10;
      Console.WriteLine(isNumber10);
    }
  }
}