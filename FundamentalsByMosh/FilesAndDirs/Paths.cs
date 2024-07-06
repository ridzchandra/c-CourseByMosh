namespace FundamentalsByMosh.FilesAndDirs;

public class Paths
{
  public static void Run()
  {
    var path = "FilesAndDirs/Example.txt";
    // Without using Path class
    var dotIndex = path.IndexOf('.');
    var extension = path.Substring(dotIndex);
    Console.WriteLine("Extension: " + extension);

    // Using Path class
    Console.WriteLine("Extension: " + Path.GetExtension(path));
    Console.WriteLine("File name: " + Path.GetFileName(path));
    Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
    Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));
  }
}
