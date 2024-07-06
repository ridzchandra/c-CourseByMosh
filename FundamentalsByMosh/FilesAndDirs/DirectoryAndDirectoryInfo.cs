namespace FundamentalsByMosh.FilesAndDirs;
public class DirectoryAndDirectoryInfo
{
  public static void Run()
  {
    var path = "../";
    // Directory.CreateDirectory(path);
    // var files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories); // returns all files with .txt extension in the current directory and its subdirectories
    // foreach (var file in files)
    // {
    //   Console.WriteLine(file);
    // }
    // var directories = Directory.GetDirectories(path, ".*", SearchOption.AllDirectories); // returns all directories that start with a dot in the current directory and its subdirectories
    // foreach (var directory in directories)
    // {
    //   Console.WriteLine(directory);
    // }
    var directoryInfo = new DirectoryInfo(path);
    var files = directoryInfo.GetFiles();
    foreach (var file in files)
    {
      Console.WriteLine(file);
    }
    var directories = directoryInfo.GetDirectories();
    foreach (var directory in directories)
    {
      Console.WriteLine(directory);
    }
  }
}
