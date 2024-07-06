namespace FundamentalsByMosh.FilesAndDirs;
public class FileAndFileInfo
{
  public static void Run()
  {
    var path = "FilesAndDirs/Example.txt";
    // File.Copy("FilesAndDirs/Example.txt", "FilesAndDirs/Example2.txt", true);
    // File.Delete("FilesAndDirs/Example2.txt");
    // if (File.Exists(path))
    // {
    //   var content = File.ReadAllText(path);
    //   Console.WriteLine(content);
    // }
    var fileInfo = new FileInfo(path);
    // fileInfo.CopyTo("FilesAndDirs/Example3.txt");
    // fileInfo.Delete();
    if (fileInfo.Exists)
    {
      var streamReader = fileInfo.OpenText();
      Console.WriteLine(streamReader.ReadToEnd());
    }
  }
}
