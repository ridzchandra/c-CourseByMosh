namespace FundamentalsByMosh
{
  class Human
  {
    public int Age;
  }
  class ReferenceAndValueTypes
  {
    public void Run()
    {
      // Value Types
      // Value types are stored on the stack
      // Value types are copied when assigned to another variable
      // Value types are instances of structs
      var a = 10;
      var b = a;
      b++;
      Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a: 10, b: 11

      // Reference Types
      // Reference types are stored on the heap
      // Reference types are not copied when assigned to another variable
      // Reference types are instances of classes, interfaces, delegates, arrays, and strings
      var array1 = new int[3] { 1, 2, 3 };
      var array2 = array1;
      array2[0] = 0;
      Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); // array1[0]: 0, array2[0]: 0

      // Value Types
      var number = 1;
      Increment(number);
      Console.WriteLine(number); // 1

      // Reference Types
      var human = new Human() { Age = 20 };
      MakeOld(human);
      Console.WriteLine(human.Age); // 30
    }
    public static void Increment(int number)
    {
      number += 10;
    }
    public static void MakeOld(Human human)
    {
      human.Age += 10;
    }
    static void Main10(string[] args)
    {
      var referenceAndValueTypes = new ReferenceAndValueTypes();
      referenceAndValueTypes.Run();
    }
  }
}