namespace AdvancedByMosh.LambdaExpressions;


class Program
{
  static void Main1(string[] args)
  {
    var books = new BookRepository().GetBooks();

    // // Without Lambda Expression
    // var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
    // foreach (var book in cheapBooks)
    //   Console.WriteLine(book.Title);

    // With Lambda Expression
    var cheapBooks = books.FindAll(book => book.Price < 10);
    foreach (var book in cheapBooks)
      Console.WriteLine(book.Title);
  }

  static bool IsCheaperThan10Dollars(Book book)
  {
    return book.Price < 10;
  }
}

