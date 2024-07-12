namespace IntermediateByMosh.Interfaces.Extensibility;

public class Program
{
  public static void Main1()
  {
    var dbMigrator = new DbMigrator(new ConsoleLogger());
    dbMigrator.Migrate();

    var dbMigrator2 = new DbMigrator(new FileLogger("log.txt"));
    dbMigrator2.Migrate();
  }
}


