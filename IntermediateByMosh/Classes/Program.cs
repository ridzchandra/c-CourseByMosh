namespace IntermediateByMosh.Classes;
public class Program
{
  public static void Main1()
  {
    UsePerson();
    // Customer.Run();
    // Point.Run();
    // Calculator.Run();
  }

  public static void UsePerson()
  {
    var person = new Person(new DateTime(1982, 1, 1));
    Console.WriteLine(person.Age);

    // The following lines can be simplified by getter and setter methods of a property.
    // person.SetBirthdate(new DateTime(1983, 1, 1));
    // Console.WriteLine(person.GetBirthdate());

    var person2 = new Person(new DateTime(1983, 1, 1));
    Console.WriteLine(person2.Age);
  }

  public static void UseHttpCookie()
  {
    var cookie = new HttpCookie();
    cookie["name"] = "Mosh";
    Console.WriteLine(cookie["name"]);
  }
}
