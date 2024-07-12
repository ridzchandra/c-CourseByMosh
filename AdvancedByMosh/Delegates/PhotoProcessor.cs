namespace AdvancedByMosh.Delegates;

public class PhotoProcessor
{
  // Delegate should have the same signature as the methods that it's going to point to, here the methods are Resize, ApplyBrightness and ApplyContrast.
  // public delegate void PhotoFilterHandler(Photo photo);

  // Instead of using a custom delegate, we can use the built-in Action delegate that comes with the .NET framework. .NET has 2 delegates that are generic, Action and Func.
  // These delegates are defined in the System namespace and can take up to 16 parameters.
  // Action delegate doesn't return a value, it's used when you want to define a method that doesn't return a value.
  // Func delegate returns a value, it's used when you want to define a method that returns a value.

  public void Process(string path, Action<Photo> filterHandler)
  {
    var photo = Photo.Load(path);


    // PhotoProcessor doesn't know what filters are going to be applied, it just knows that it has to call the filterHandler. It's the responsibility of the client to specify what filters to apply. The client can even define a new filter and make it follow the same signature as the other filters. That way this code doesn't have to be modified and hence is open for extension but closed for modification.
    filterHandler(photo);

    photo.Save();
  }
}
