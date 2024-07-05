namespace FundamentalsByMosh
{
  class Strings
  {
    public void Run()
    {
      // String
      // You can use `string` keyword or `System.String` class to declare a string variable
      // just like how you can use `int` keyword or `System.Int32` struct to declare an integer variable
      // Essentially these keywords are aliases to the classes/structs in the .NET framework
      string firstName = "Mosh";
      String lastName = "Hamedani";

      string name = firstName + " " + lastName;
      string fullName = string.Format("My name is {0} {1}", firstName, lastName);
      string[] names = new string[3] { "Jack", "John", "Mary" };
      string formattedNames = string.Join(", ", names);

      Console.WriteLine(name); // Mosh Hamedani
      Console.WriteLine(fullName); // My name is Mosh Hamedani
      Console.WriteLine(formattedNames); // Jack, John, Mary

      // Verbatim String
      string path = "c:\\projects\\project1\\folder1";
      string verbatimPath = @"c:\projects\project1\folder1";

      var text = "Hi John and welcome to the course\nLook into the following paths\nc:\\projects\\project1\\folder1\nc:\\projects\\project2\\folder2";
      var verbatimText = @"Hi John and welcome to the course
Look into the following paths
c:\projects\project1\folder1
c:\projects\project2\folder2";

      Console.WriteLine(path); // c:\projects\project1\folder1
      Console.WriteLine(verbatimPath); // c:\projects\project1\folder1
      Console.WriteLine(text);
      Console.WriteLine(verbatimText);

      // String Interpolation
      string interpolatedName = $"{firstName} {lastName}";
      string interpolatedFullName = $"My name is {firstName} {lastName}";
      string interpolatedFormattedNames = $"{names[0]}, {names[1]}, {names[2]}";

      Console.WriteLine(interpolatedName); // Mosh Hamedani
      Console.WriteLine(interpolatedFullName); // My name is Mosh Hamedani
      Console.WriteLine(interpolatedFormattedNames); // Jack, John, Mary

      string project1 = "project1";
      string project2 = "project2";
      string folder1 = "folder1";
      string folder2 = "folder2";

      string verbatimInterpolatedText = $@"Hi John and welcome to the course
Look into the following paths
c:\projects\{project1}\{folder1}
c:\projects\{project2}\{folder2}";

      Console.WriteLine(verbatimInterpolatedText);

      // String Methods
      string str = "Hello World";
      Console.WriteLine(str.ToUpper()); // HELLO WORLD
      Console.WriteLine(str.ToLower()); // hello world
      Console.WriteLine(str.Trim()); // Hello World
      Console.WriteLine(str.IndexOf('o')); // 4
      Console.WriteLine(str.LastIndexOf('o')); // 7
      Console.WriteLine(str.Substring(6)); // World
      Console.WriteLine(str.Substring(6, 3)); // Wor
      Console.WriteLine(str.Replace("World", "C#")); // Hello C#
      Console.WriteLine(str.Replace('o', 'O')); // HellO WOrld
      Console.WriteLine(str.Remove(5)); // Hello
      Console.WriteLine(str.Remove(5, 3)); // Hellorld
    }
    static void Main8(string[] args)
    {
      var strings = new Strings();
      strings.Run();
    }
  }
}