namespace FundamentalsByMosh.Strings
{
  public class Strings
  {
    public static void Run()
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

      // N ull and empty strings
      string empty = "";
      string whitespace = " ";
      string nullString = null;

      Console.WriteLine(String.IsNullOrEmpty(empty)); // True
      Console.WriteLine(String.IsNullOrEmpty(whitespace)); // False
      Console.WriteLine(String.IsNullOrEmpty(nullString)); // True

      Console.WriteLine(String.IsNullOrWhiteSpace(empty)); // True
      Console.WriteLine(String.IsNullOrWhiteSpace(whitespace)); // True
      Console.WriteLine(String.IsNullOrWhiteSpace(nullString)); // True

      // Split
      var strArray = str.Split(' '); // ["Hello", "World"]
      Console.WriteLine(strArray[0]); // Hello
      Console.WriteLine(strArray[1]); // World

      // Convert
      string number = "1234";
      int intNumber = Convert.ToInt32(number); // If the string is null or empty, it will return 0 (default value for int)
      Console.WriteLine(intNumber); // 1234
      int intNumber2 = int.Parse(number); // If the string is null or empty, it will throw an exception
      Console.WriteLine(intNumber2); // 1234

      // Convert to string
      int intNumber3 = 1234;
      string number2 = intNumber3.ToString();
      Console.WriteLine(number2); // 1234
      string currency = intNumber3.ToString("C"); // Currency
      Console.WriteLine(currency); // $1,234.00
      string currency2 = intNumber3.ToString("C0"); // Currency without decimal
      Console.WriteLine(currency2); // $1,234
      string percentage = intNumber3.ToString("P"); // Percentage
      Console.WriteLine(percentage); // 123,400.00%
      string custom = intNumber3.ToString("00.00"); // Custom format
      Console.WriteLine(custom); // 1234.00
    }
  }
}