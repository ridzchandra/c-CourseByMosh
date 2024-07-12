namespace IntermediateByMosh.Classes;

public class Calculator
{
  public int Add(params int[] numbers)
  {
    var sum = 0;
    foreach (var number in numbers)
    {
      sum += number;
    }
    return sum;
  }

  public static void Run()
  {
    var calculator = new Calculator();
    Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
    Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
  }
}
