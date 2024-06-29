// To compile your code use the command `dotnet build` in the terminal or `cmd + shift + B` and select `dotnet build` in the dropdown. This will create a `bin` directory in your project directory with the compiled code. To run the compiled code use the command `dotnet run` in the terminal. This will run the compiled code in the terminal.

namespace Variables
{
    class Program
  {
    static void Main2(string[] args)
    {
      byte number = 2;
      int count = 10;
      // Your literal on the right should match the type of the variable on the left. For example, if you have a float variable, you should use a 'f' suffix.
      float totalPrice = 20.95f;
      // For char you have to use single quotes. Double quotes are for strings.
      char character = 'A';
      string firstName = "Mosh";
      bool isWorking = false;
      
      // You can use var to declare a variable without specifying the type. The type will be inferred by the compiler.
      // When you use var, and use a integer literal, by default it will infer the type as int.
      // If you want any other size of integer, you have to specify the type explicitly instead of var.
      var number2 = 2;


    
      // You can use code snippet `cw` to write `Console.WriteLine();` in Visual Studio Code.
      Console.WriteLine(number);
      Console.WriteLine(count);
      Console.WriteLine(totalPrice);
      Console.WriteLine(character);
      Console.WriteLine(firstName);
      Console.WriteLine(isWorking);
      Console.WriteLine(number2);

      // Format Strings:
      // You can use format strings to format your output. You can use placeholders like {0}, {1}, {2} etc. and pass the values as arguments to the `WriteLine` method.
      Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
      Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

      // Constants:
      const float Pi = 3.14f;
      // Pi = 1; // This will give an error because you cannot change the value of a constant.
      Console.WriteLine(Pi);
    }
  }
  
}