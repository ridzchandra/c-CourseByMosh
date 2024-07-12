namespace IntermediateByMosh.Classes;
public class Person
{
  // You can use "prop" code snippet to create an auto implemented property.
  public string Name { get; set; }
  public string Username { get; set; }
  public DateTime Birthdate { get; private set; }

  public int Age
  {
    get
    {
      var timeSpan = DateTime.Today - Birthdate;
      var years = timeSpan.Days / 365;
      return years;
    }

    // For properties that you don't want to be set from outside the class, you can skip the set method to make the property readonly.
    // If the property is a an auto implemented property, you can either remove the set method to make it readonly or make it private. for example: You don't want to set the age and birthdate of a person from outside the class as birthdate doesn't change for a person. Your class should always represent a valid state.
  }

  // The following methods can be simplified by getter and setter methods of a property. 
  // public void SetBirthdate(DateTime birthdate)
  // {
  //   _birthdate = birthdate;
  // }

  // public DateTime GetBirthdate()
  // {
  //   return _birthdate;
  // }

  public Person(DateTime birthdate)
  {
    Birthdate = birthdate;
  }



}
