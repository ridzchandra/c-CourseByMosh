namespace AdvancedByMosh.Linq;

public class Program
{
  public static void Main1()
  {
    var books = new BookRepository().GetBooks();

    // Without LINQ
    var cheapBooks = new List<Book>();
    foreach (var book in books)
    {
      if (book.Price < 10)
      {
        cheapBooks.Add(book);
      }
    }

    // LINQ Query Operators (SQL-like syntax) is equivalent to the extension methods
    // Internally, all LINQ Query Operators are converted to LINQ Extension Methods
    // LINQ Query Operators always start with 'from' and end with 'select'
    var cheapBooks2 = from book in books
                      where book.Price < 10
                      orderby book.Title
                      select book.Title;

    // LINQ Extension Methods
    // They are more powerful and flexible
    // In complex scenarios, they don't have enough query operators for every extension method we have.
    // They can be chained together
    var cheapBook3 = books
      .Where(book => book.Price < 10)
      .OrderBy(book => book.Title)
      .Select(book => book.Title); // Select is used to project(transform) the result

    foreach (var book in cheapBooks2)
    {
      Console.WriteLine(book);
    }

    // Similar to Where but returns a single element
    // Throws an exception if no element is found
    // If multiple elements are found, it throws an exception as well.
    var aspMvcBook = books.Single(book => book.Title == "ASP.NET MVC");
    Console.WriteLine(aspMvcBook.Title);

    // Similar to Single but returns default(null in this case) if no element is found
    // Throws an exception if multiple elements are found
    var aspMvcBook2 = books.SingleOrDefault(book => book.Title == "ASP.NET MVC");

    // Similar to Single but returns the first element if multiple elements are found
    // We also have FirstOrDefault, Last, LastOrDefault
    var aspMvcBook3 = books.First(book => book.Title == "C# Advanced Topics");
    Console.WriteLine(aspMvcBook3.Title + " " + aspMvcBook3.Price);

    // Skip and Take
    // These are used for paging
    // Skip(2) skips the first 2 elements
    // Take(3) takes the next 3 elements
    var pagedBooks = books.Skip(2).Take(3);
    foreach (var book in pagedBooks)
    {
      Console.WriteLine(book.Title);
    }

    // Aggregation Methods
    // Count, Max, Min, Average, Sum
    var count = books.Count();
    var maxPrice = books.Max(book => book.Price);
    var minPrice = books.Min(book => book.Price);
    var averagePrice = books.Average(book => book.Price);
    var totalPrice = books.Sum(book => book.Price);

    Console.WriteLine($"Count: {count}"); // 5
    Console.WriteLine($"Max Price: {maxPrice}"); // 12
    Console.WriteLine($"Min Price: {minPrice}"); // 5
    Console.WriteLine($"Average Price: {averagePrice}"); // 8.38
    Console.WriteLine($"Total Price: {totalPrice}"); // 41

    // Grouping
    // GroupBy returns a collection of IGrouping<TKey, TElement>
    // IGrouping<TKey, TElement> is similar to Dictionary<TKey, TElement>
    // TKey is the key of the group
    // TElement is the element of the group
    // It essentially behaves like an IEnumerable<TElement> with an additional property named Key.
    // IEnumerable<TElement>: Allows iteration over a collection of TElement.
    // IGrouping<TKey, TElement>: Extends IEnumerable<TElement> by adding a Key property.This enables not only iteration over a collection of TElement but also provides a way to identify the group by its key (TKey).
    var groupedBooks = books.GroupBy(book => book.Price);
    foreach (var group in groupedBooks)
    {
      Console.WriteLine($"Price: {group.Key}");
      foreach (var book in group)
      {
        Console.WriteLine($"  {book.Title}");
      }
    }
  }
}
