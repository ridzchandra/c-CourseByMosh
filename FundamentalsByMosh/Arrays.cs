namespace FundamentalsByMosh
{
  class Arrays
  {
    public void Run()
    {
      var numbers = new int[3];
      numbers[0] = 1;

      Console.WriteLine(numbers[0]); // 1
      Console.WriteLine(numbers[1]); // 0 (default value for int when not assigned)
      Console.WriteLine(numbers[2]); // 0 (default value for int when not assigned)

      bool[] flags = new bool[3];
      flags[0] = true;

      Console.WriteLine(flags[0]); // True
      Console.WriteLine(flags[1]); // False (default value for bool when not assigned)
      Console.WriteLine(flags[2]); // False (default value for bool when not assigned)

      //  Shorthand object initialization syntax
      string[] names = new string[3] { "Jack", "John", "Mary" };

      Console.WriteLine(names[0]); // Jack
      Console.WriteLine(names[1]); // John
      Console.WriteLine(names[2]); // Mary
    }
    static void Main7(string[] args)
    {
      var arrays = new Arrays();
      arrays.Run();
    }
  }
}