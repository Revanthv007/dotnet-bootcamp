constructors are special methods used to initialize objects of a class or in otherwords allocate memory for Instance members.
It initializes fields to their default values (e.g., 0 for integers, null for objects...etc).
We need to write a constructor only when if we want to initialize instance members with some values or to do some operation while object is initializing or memory is getting allocated.

1. Types of Constructors in C#
1.1 Default Constructor
  A default constructor is a parameterless constructor that C# automatically provides if no constructors are exists in a class.
  
  Example:- System Defined Default Constructor
  class Sample
  {
      // Default constructor (added by the compiler if none is defined)
  }
1.1.1 Parameterless Constructor
  Example:- User Defined Parameterless constructor
  class Sample
  {
      public int Number;
      // Default constructor 
      public Sample()
      {
          Number = 5; // Default initialization
        //Here for all objects Number value will be 5.
      }
  }
  When to Use: Use default constructors for basic initialization, especially if you need default values for all objects without passing parameters.

1.2 Parameterized Constructor
  A parameterized constructor accepts arguments, allowing different ways to initialize an object with specific values at the time of creation.
  
  Example:
  class Person
  {
      public string Name;
      public int Age;

      //we can have multiple constructors in one class //Constructor/Method Overloading
      public Person()
      {
      }
  
      // Parameterized constructor
      public Person(string name, int age)
      {
          Name = name;
          Age = age;
      }
  }
  Person obj = new Person("iConnect", 20);//Approach using Parameterized constructor
  Person obj1 = new Person();//Approach using default constructor
  obj1.Name = "iConnect";
  obj1.Age = 20;

  When to Use: Use parameterized constructors when you want to initialize an object with specific values passed at creation time.

1.3 Private Constructor
A private constructor restricts object creation outside of the class, which is useful in singleton patterns or for classes that don’t require instance creation.

Example:
class Singleton
{
    private static Singleton instance = null;

    // Private constructor to restrict instantiation
    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (instance == null)
            instance = new Singleton();
        return instance;
    }
}
When to Use: Use a private constructor in singleton design patterns or when a class only contains static members and should not be instantiated.

1.4 Static Constructor
A static constructor initializes static members of the class. It is automatically called once when the class is first accessed. Static constructors cannot take parameters and are marked by the static keyword.

Example:
class Utility
{
    public static int GlobalCounter;

    // Static constructor
    static Utility()
    {
        GlobalCounter = 0;
        Console.WriteLine("Static constructor called");
    }

    public Utility()
    {

        GlobalCounter++;
    }
}
When to Use: Use a static constructor for one-time initialization of static data when the class is first accessed.

1.5 Copy Constructor
A copy constructor creates a new object by copying an existing object. C# doesn’t provide a built-in copy constructor, but it can be implemented manually.

Example:
class Rectangle
{
    public int Length;
    public int Width;

    // Parameterized constructor
    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }

    // Copy constructor
    public Rectangle(Rectangle other)
    {
        Length = other.Length;
        Width = other.Width;
    }
}
When to Use: Use a copy constructor when you want to create a new object with the same values as an existing object.

2. Constructor Calling Mechanism
Order of Execution: Constructors are called when an object is created, starting with the base class constructor, followed by derived class constructors.
Constructor Overloading: C# allows multiple constructors with different signatures in the same class (overloading). The appropriate constructor is selected based on the arguments passed during object creation.

Example of Constructor Overloading:
class Example
{
    public int Value;

    // Default constructor
    public Example()
    {
        Value = 10;
    }

    // Parameterized constructor
    public Example(int value)
    {
        Value = value;
    }
}

class Program
{
    static void Main()
    {
        Example obj1 = new Example();     // Calls default constructor
        Example obj2 = new Example(100);  // Calls parameterized constructor
    }
}
3. Constructor Execution Mechanism
Static Constructor Execution: Static constructors are executed only once when the class is first accessed, even if no instances are created.
Instance Constructor Execution: When an object is created, instance constructors are called. If the class has multiple constructors, the one matching the arguments used during instantiation is selected.
Execution Order Example with Static and Instance Constructors:

class Sample
{
    public static int Counter;

    // Static constructor
    static Sample()
    {
        Counter = 1;
        Console.WriteLine("Static Constructor called.");
    }

    // Instance constructor
    public Sample()
    {
        Console.WriteLine("Instance Constructor called.");
    }
}

class Program
{
    static void Main()
    {
        Sample s1 = new Sample(); // Triggers both static and instance constructors
        Sample s2 = new Sample(); // Only instance constructor is called (static already executed)
    }
}
Output:
Static Constructor called.
Instance Constructor called.
Instance Constructor called.
Explanation:

The static constructor is called only once, the first time the class Sample is used.
Each time an object is created, the instance constructor is called.
