namespace IntermediateByMosh.Polymorphism.Excercises;

public class DbCommand
{
  private DbConnection _connection;
  private DbConnection Connection
  {
    get
    {
      return _connection;
    }
    set
    {
      if (value == null)
      {
        throw new ArgumentNullException("Db connection can't be 'null' to create a db command!");
      }
      _connection = value;
    }
  }

  private string _command;
  public string Command
  {
    get
    { return _command; }
    set
    {
      if (string.IsNullOrWhiteSpace(value))
      {
        throw new ArgumentNullException("Command to execute on the db can't be empty, null or whitespace!");
      }
      _command = value;
    }
  }
  public DbCommand(DbConnection connection, string command)
  {
    Connection = connection;
    Command = command;
  }

  public void Execute()
  {
    Connection.Open();
    Console.WriteLine($"Executing {Command}");
    Connection.Close();
  }
}
