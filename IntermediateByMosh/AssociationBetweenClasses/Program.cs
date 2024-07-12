namespace IntermediateByMosh.AssociationBetweenClasses;
public class Program
{
  public static void Main1()
  {
    // UseInheritance();
    UseComposition();
  }

  public static void UseComposition()
  {
    var dbMigrator = new DbMigrator(new Logger());
    dbMigrator.Migrate();

    var installer = new Installer(new Logger());
    installer.Install();
  }
  public static void UseInheritance()
  {
    var text = new Text();
    text.Width = 100;
    text.Copy();
  }
}

