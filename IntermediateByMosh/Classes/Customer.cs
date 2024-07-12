namespace IntermediateByMosh.Classes;
public class Customer
{
  public int Id;
  public string Name;
  readonly public List<Order> Orders = new List<Order>();

  // You can use "ctor" code snippet to create a constructor.
  public Customer()
  {
    // Initialize Orders to an empty list to avoid null reference exceptions. It's a good practice to initialize collections in the constructor.
    // However, initialising fields like this which don't depend on external values inside the default constructor is not preferred by some devs coz, we'll have to make sure all other constructor overloads call this constructor. Instead they initialise the field inline. as shown above.
    // Orders = new List<Order>();

    // Some devs don't like to initialise some fields inline and some in the constructor and they do all of them inside the constructor regardless of whether they depend on external values or not.

    // No matter which approach you choose, just be consistent.
  }

  // When you have multiple overloads for your constructor, you should chain them together as shown below. This way, you avoid code duplication.
  // However, this pattern can be a bit confusing because of how it makes the control flow jump around. So, use it sparingly.
  // As a good practice, you should only create constructors that are actually needed by your class for initialization.
  // Here for example, we don't need constructors to initialise Id and Name. We can use object initializers instead. https://www.notion.so/Object-Initialisers-e3223ee01bec407d939841c5c87e463e
  public Customer(int id)
    : this()
  {
    this.Id = id;
  }

  public Customer(int id, string name)
    : this(id)
  {
    this.Name = name;
  }

  public void Promote()
  {
    // Orders = new List<Order>(); // A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer i.e, inline) - compiler error
  }

  public static void Run()
  {
    var customer = new Customer(1, "John");
    Console.WriteLine(customer.Id);
    Console.WriteLine(customer.Name);

    customer.Orders.Add(new Order());
    customer.Orders.Add(new Order());
    Console.WriteLine(customer.Orders.Count); // 2
  }
}
