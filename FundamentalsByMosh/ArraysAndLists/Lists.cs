namespace FundamentalsByMosh.ArraysAndLists;

public class Lists
{
  public static void Run()
  {
    // Lists
    var numbers = new List<int>() { 1, 2, 3, 4 };
    numbers.Add(1);
    numbers.AddRange(new int[3] { 5, 6, 7 });
    foreach (var number in numbers)
    {
      Console.WriteLine(number); // 1, 2, 3, 4, 1, 5, 6, 7
    }
    Console.WriteLine();

    Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // 0
    Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1)); // 4
    Console.WriteLine("Count: " + numbers.Count); // 8

    numbers.Remove(1); // Removes the first 1
    foreach (var number in numbers)
    {
      Console.WriteLine(number); // 2, 3, 4, 1, 5, 6, 7
    }
    Console.WriteLine();

    // Remove all 1s - use a for loop. We can't use a foreach loop because we are modifying the list while iterating over it.
    for (int i = 0; i < numbers.Count; i++)
    {
      if (numbers[i] == 1)
      {
        numbers.Remove(numbers[i]); // Removes all 1s
      }
    }
    foreach (var number in numbers)
    {
      Console.WriteLine(number); // 2, 3, 4, 5, 6, 7
    }

    numbers.Clear(); // Removes all elements
    Console.WriteLine("Count: " + numbers.Count); // 0
  }
}


