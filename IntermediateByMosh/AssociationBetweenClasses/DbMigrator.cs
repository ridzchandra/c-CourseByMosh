namespace IntermediateByMosh.AssociationBetweenClasses;

public class DbMigrator
{
  private readonly Logger _logger;

  public DbMigrator(Logger logger)
  {
    _logger = logger;
  }

  public void Migrate()
  {
    _logger.Log("Migration started at " + DateTime.Now);
    // Details of migrating the database
    _logger.Log("Migration finished at " + DateTime.Now);
  }
}

