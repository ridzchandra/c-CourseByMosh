namespace IntermediateByMosh.Polymorphism.Excercises;
public abstract class DbConnection
{
  private string _connectionString;
  protected string ConnectionString
  {
    get
    { return _connectionString; }
    private set
    {
      if (string.IsNullOrWhiteSpace(value))
      {
        throw new ArgumentException("Connection string can't be 'null', empty or whitespace!");
      }
      _connectionString = value;
    }
  }
  protected TimeSpan Timeout { get; } = TimeSpan.FromSeconds(10);

  public DbConnection(string connectionString)
  {
    ConnectionString = connectionString;
  }

  public abstract void Open();
  public abstract void Close();

}
