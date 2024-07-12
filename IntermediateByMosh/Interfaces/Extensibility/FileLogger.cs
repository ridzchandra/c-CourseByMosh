namespace IntermediateByMosh.Interfaces.Extensibility;

public class FileLogger : ILogger
{
  private readonly string _path;

  public FileLogger(string path)
  {
    _path = path;
  }
  public void LogError(string message)
  {
    Log(message, "Error");
  }

  public void LogInfo(string message)
  {
    Log(message, "Info");
  }

  public void Log(string message, string messageType)
  {
    // using statement in C# is used for working with resources that need to be disposed of after use, such as file streams, database connections, or network connections. These resources implement the IDisposable interface, which includes a Dispose method to clean up the resource. Without the using statement, you would need to manually call Dispose or Close in a finally block, which can be error-prone.
    using (var streamWriter = new StreamWriter(_path, true))
    {
      streamWriter.WriteLine(messageType + ": " + message);
    }
  }
}


