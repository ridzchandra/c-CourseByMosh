namespace AdvancedByMosh.NullableTypes;

class Program
{
  static void Main1()
  {
    // Nullable types
    // Nullable types are value types that can be null
    // Nullable types are instances of the System.Nullable<T> struct
    // Nullable types are useful when you want to represent an optional value

    // Nullable types can be written as:
    // Nullable<DateTime> date = null;
    DateTime? date = null; // syntactic sugar - same as above
    Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
    Console.WriteLine("HasValue: " + date.HasValue);
    // Console.WriteLine("Value: " + date.Value); // throws InvalidOperationException if HasValue is false

    // DateTime date2 = date;// Cannot implicitly convert type 'System.DateTime?' to 'System.DateTime'
    DateTime date2 = date.GetValueOrDefault(); // default value of DateTime is 1/1/0001 12:00:00 AM
    // date2 = (DateTime)date; // explicit casting is required if you want to assign a nullable type to a non-nullable type. In this case, it will throw an InvalidOperationException if the nullable type is null
    date2 = DateTime.Now;

    date = date2; // implicit conversion from non-nullable to nullable type is allowed
    Console.WriteLine("date: " + date);

    // Null coalescing operator
    // The null coalescing operator (??) is used to assign a default value to a nullable type
    // If the nullable type has a value, the value is returned
    // If the nullable type is null, the default value is returned
    date = null;
    DateTime date3 = date ?? DateTime.Today;
    Console.WriteLine("date3: " + date3);
    // Similar to ternary operator
    date3 = date != null ? date.GetValueOrDefault() : DateTime.Today;
  }
}