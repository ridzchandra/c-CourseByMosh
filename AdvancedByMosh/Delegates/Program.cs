namespace AdvancedByMosh.Delegates;

public class Program
{
  public static void Main1(string[] args)
  {
    var processor = new PhotoProcessor();
    var filters = new PhotoFilters();

    var filterHandler = filters.ApplyBrightness;
    filterHandler += filters.ApplyContrast;
    filterHandler += RemoveRedEyeFilter;

    processor.Process("photo.jpg", filterHandler);
  }


  // This method has the same signature as the other filters, so it can be added to the filterHandler delegate. This way the PhotoProcessor class doesn't have to be modified.
  // We're extending the functionality of the PhotoProcessor class without modifying it.
  // We also didn't have to modify the PhotoFilters class which we released as a library (Framework) to the clients.
  static void RemoveRedEyeFilter(Photo photo)
  {
    Console.WriteLine("Apply RemoveRedEye");
  }
}


