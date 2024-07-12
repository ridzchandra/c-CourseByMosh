namespace IntermediateByMosh.Polymorphism.Excercises;
public class Program
{
  public static void Main1(string[] args)
  {
    // Excercise1();
    Excercise2();
  }

  public static void Excercise1()
  {
    var sqlServerConnection = new SqlConnection("sql-server-conn");
    sqlServerConnection.Open(); // Might throw an exception
    sqlServerConnection.Close();
    var oracleConnection = new OracleConnection("oracle-conn");
    oracleConnection.Open(); // Might throw an exception
    oracleConnection.Close();
    // var oracleConnection2 = new OracleConnection(null); Will throw an exception
  }

  public static void Excercise2()
  {
    var sqlServerConnection = new SqlConnection("sql-server-conn");
    var oracleConnection = new OracleConnection("oracle-conn");

    var sqlServerCommand = new DbCommand(sqlServerConnection, "sql server command");
    var oracleCommand = new DbCommand(oracleConnection, "oracle command");

    sqlServerCommand.Execute();
    oracleCommand.Execute();
  }

}
