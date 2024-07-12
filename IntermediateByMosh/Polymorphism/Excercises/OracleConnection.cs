namespace IntermediateByMosh.Polymorphism.Excercises;

public class OracleConnection : DbConnection
{
  public OracleConnection(string connectionString) : base(connectionString) { }

  public override void Open()
  {
    Console.WriteLine($"Openning connection with connection string: {ConnectionString}");
    var openingDuration = TimeSpan.FromSeconds(new Random().Next(11));
    if (openingDuration > Timeout)
    {
      throw new TimeoutException($"Couldn't open Oracle connection in {Timeout.TotalSeconds} seconds!");
    }
  }

  public override void Close()
  {
    Console.WriteLine("Closing Oracle connection...");
  }
}
