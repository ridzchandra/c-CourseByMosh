namespace IntermediateByMosh.AssociationBetweenClasses;

public class Installer
{
  private readonly Logger _logger;

  public Installer(Logger logger)
  {
    _logger = logger;
  }

  public void Install()
  {
    _logger.Log("Installation started at " + DateTime.Now);
    // Details of installing the application
    _logger.Log("Installation finished at " + DateTime.Now);
  }
}

