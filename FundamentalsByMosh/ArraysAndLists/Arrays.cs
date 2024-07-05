namespace FundamentalsByMosh.ArraysAndLists;

public class Arrays
{
  public static void Run()
  {
    // Arrays
    var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

    // Length
    Console.WriteLine("Length: " + numbers.Length); // 6

    // IndexOf()
    var index = Array.IndexOf(numbers, 9);
    Console.WriteLine("Index of 9: " + index); // 2

    // Clear()
    // Clear() sets the elements in the array to their default value (0 for int), (null for reference types), (false for bool), (0.0 for float/double) etc.
    Array.Clear(numbers, 0, 2);
    Console.WriteLine("Effect of Clear()");
    foreach (var n in numbers)
    {
      Console.WriteLine(n); // 0 0 9 2 14 6
    }

    // Copy()
    int[] another = new int[3];
    Array.Copy(numbers, another, 3);
    Console.WriteLine("Effect of Copy()");
    foreach (var n in another)
    {
      Console.WriteLine(n); // 0 0 9
    }

    // Sort()
    Array.Sort(numbers);
    Console.WriteLine("Effect of Sort()");
    foreach (var n in numbers)
    {
      Console.WriteLine(n); // 0 0 2 6 9 14
    }

    // Reverse()
    Array.Reverse(numbers);
    Console.WriteLine("Effect of Reverse()");
    foreach (var n in numbers)
    {
      Console.WriteLine(n); // 14 9 6 2 0 0
    }
  }
}


