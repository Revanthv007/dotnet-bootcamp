1.
using System;

class Program1
{
    public static void StaticMethod()
    {
        Console.WriteLine("Static method called.");
    }

    public void NonStaticMethod()
    {
        Console.WriteLine("Non-static method called.");
        StaticMethod(); 
    }

    static void Main()
    {
        Program1.StaticMethod();
        //Static method called.

        Program1 obj = new Program1(); //Created Instance for Program1 Class
        obj.NonStaticMethod();
        //Inside NonStaticMethod There is A StaticMethod.
        //Non-static method called.
        //Static method called
        NonStaticMethod();
        //We cant invoke the NonStaticMethod Without Creating Instance to it.  
    }
}

2. 
using System;

class Program2
{
    static void ModifyValue(ref int value)
    {
        value += 10;
    }

    static void Main()
    {
        int number = 5;
        Console.WriteLine("Before: " + number);
        //Before: 

        ModifyValue(ref number); // 5
        Console.WriteLine("After: " + number);
        //After: 15
    }
}

3.
using System;

class Program3
{
    static void CalculateValues(int input, out int doubled, out int tripled)
    {
        doubled = input * 2; //3*2 = 6
        tripled = input * 3; //3*3 = 9
    }

    static void Main()
    {
        int a, b;
        CalculateValues(3, out a, out b);
        Console.WriteLine($"Doubled: {a}, Tripled: {b}");
        //Doubled: 6, Tripled: 9
    }
}

4. 
using System;

class Program4
{
    static void ModifyValue(ref int value)
    {
        value += 10;
    }

    static void Main()
    {
        ModifyValue(ref value); //Error
        int number = 5;
        ModifyValue(ref number);
        Console.WriteLine("After modification: " + number);
    }
}

5. 
using System;

class Program5
{
    static void PrintDetails(string name, int age = 18, string country = "USA")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Country: {country}");
    }

    static void Main()
    {
        PrintDetails("Alice");
        //Name: Alice, Age: 18, Country: USA
        PrintDetails("Bob", 25);
        //Name: Bob, Age: 25, Country: USA
        PrintDetails("Charlie", 30, "Canada");
        //Name: Charlie, Age: 30, Country: Canada
    }
}
6.
using System;

class Program6
{
    static void UpdateValue(ref int value, int increment = 5)
    {
        value += increment;
    }

    static void Main()
    {
        int number = 10;

        UpdateValue(ref number);
        Console.WriteLine("After default increment: " + number);
        //After default increment: 15 //10+5=15

        UpdateValue(ref number, 15);
        Console.WriteLine("After custom increment: " + number);
        //After custom increment: 30
    }
}
7.
using System;

class Program7
{
    static void GenerateNumbers(out int x, out int y)
    {
        x = 10;
        y = 20;
    }

    static void Main()
    {
        int a, b;
        GenerateNumbers(out a, out b);
        Console.WriteLine($"Generated numbers: {a} and {b}");
        //Generated numbers: 10 and 20
    }
}

8.
using System;

class Program8
{
    static void Calculate(out int x, int y)
    {
        x = y * 2;
    }

    static void Main()
    {
        int result;
        Calculate(out result, 5);
        Console.WriteLine(result);
        //10

        Calculate(out int result);
        //Error
    }
}
9.
using System;

class Program9
{
    static void DisplayInfo(string name, int age = 18, string country = "USA")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Country: {country}");
    }

    static void Main()
    {
        DisplayInfo("Alice", "Canada");
        //Error

        DisplayInfo("Bob", country: "Canada");
        //Name: Bob, Age: 18, Country: Canada
    }
}

10.
using System;

class Program10
{
    static void ModifyNumbers(ref int x, out int y)
    {
        x *= 2;
        y = x + 10;
    }

    static void Main()
    {
        int a = 5, b;
        ModifyNumbers(ref a, out b);// 5*2=10, y = 10+10 = 20

        Console.WriteLine($"Modified a: {a}, Calculated b: {b}");
        //Modified a: 10, Calculated b: 20

        ModifyNumbers(ref a, out b);
        // 10*2=20 //30
    }
}

11.
using System;

class Program11
{
    static void ModifyValues(ref int x, out int y, int increment = 5)
    {
        x += increment;
        y = x * 2;
    }

    static void Main()
    {
        int a = 10, b;
        
        ModifyValues(ref a, out b);
        Console.WriteLine($"After ModifyValues - a: {a}, b: {b}");

        ModifyValues(ref a, out b, 10); // Custom increment
        Console.WriteLine($"After ModifyValues with increment 10 - a: {a}, b: {b}");
    }
    //After ModifyValues - a: 15, b: 30
    //After ModifyValues with increment 10 - a: 25, b: 50
}

12.
using System;

class Program12
{
    public int instanceValue = 100;

    public static void StaticMethod()
    {
        Console.WriteLine("Instance Value: " + instanceValue); //Error
    }

    public void InstanceMethod()
    {
        Console.WriteLine("Instance Value: " + instanceValue);
    }

    static void Main()
    {
        Program12 obj = new Program12();
        obj.InstanceMethod();
        //Instance Value: 100
        StaticMethod();
    }
}
13.
using System;

class Program13
{
    public static void Calculate(int x, int y = 2)
    {
        Console.WriteLine("Product: " + (x * y));
    }

    public static void Calculate(int x, int y, int z)
    {
        Console.WriteLine("Sum: " + (x + y + z));
    }

    static void Main()
    {
        Calculate(5);
        //Product: " + 10
        Calculate(5, 3);
        //Product: " 15
        Calculate(1, 2, 3);
        //Sum: 6
    }
}
14.
using System;

class Program14
{
    static void ModifyArray(ref int[] arr)
    {
        arr[0] = 99;
        arr = new int[] { 9, 8, 7 };
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3 };
        Console.WriteLine("Before: " + string.Join(", ", numbers));
        //Before: 1,2,3
        
        ModifyArray(ref numbers);
        Console.WriteLine("After: " + string.Join(", ", numbers));
    }
    //Before: 1, 2, 3
    //After: 9, 8, 7
}

15.
using System;

class Program15
{
    public static void PrintNumbers(int count, int limit = 10)
    {
        if (count > limit)
            return;
        
        Console.WriteLine(count);
        PrintNumbers(count + 1, limit);
    }

    static void Main()
    {
        PrintNumbers(1);
        //12345678910
    }
}

16.
using System;

class Program16
{
    static void DisplayMessage(string message = "Hello", int times = 1, bool uppercase = false)
    {
        string output = uppercase ? message.ToUpper() : message;

        for (int i = 0; i < times; i++)
            Console.WriteLine(output);
    }

    static void Main()
    {
        DisplayMessage();
        //Hello
        DisplayMessage("Custom Message", 2);
        //Custom Message
        //Custom Message
        DisplayMessage("Custom Upper", 3, true);
        //CUSTOM UPPER
        //CUSTOM UPPER
        //CUSTOM UPPER
    }
}

17.
using System;

class Program17
{
    static int DoubleValue(ref int x)
    {
        x *= 2;
        return x;
    }

    static void IncrementValue(out int x)
    {
        x = 5;
        x += 1;
    }

    static void Main()
    {
        int a = 10;
        IncrementValue(out a); //6
        int result = DoubleValue(ref a); //12

        Console.WriteLine($"Final Result: {result}, Modified Value: {a}");
    }
    //Final Result: 12, Modified Value: 12
}

18.
using System;

class Program18
{
    public void Display(string message)
    {
        Console.WriteLine("String message: " + message);
    }

    public void Display(int number)
    {
        Console.WriteLine("Integer message: " + number);
    }

    public void Display(int number, string text = "Default Text")
    {
        Console.WriteLine($"Number: {number}, Text: {text}");
    }

    static void Main()
    {
        Program18 obj = new Program18();
        obj.Display("Hello");
        //String message: Hello
        obj.Display(10);
        //Integer message: 10
       
        obj.Display(5, "Custom Text");
        //Number: 5, Text: Custom Text
    }
}

19.
using System;

class Program19
{
    private void PrivateMethod()
    {
        Console.WriteLine("Private method called");
    }

    public void CallPrivateMethod()
    {
        Console.WriteLine("Public method calling private method:");
        PrivateMethod();
    }

    static void Main()
    {
        Program19 obj = new Program19();
        obj.CallPrivateMethod();
        //Public method calling private method:
        //Private method called
        
        obj.PrivateMethod();
        //Private method called
    }
}

20.
using System;

class Program20
{
    static void CalculateValues(int input, out int square, out int cube)
    {
        square = input * input;
        cube = input * input * input;
    }

    static void Main()
    {
        int a, b;
        CalculateValues(3, out a, out b);

        Console.WriteLine($"Square: {a}, Cube: {b}");
        //Square: 9, Cube: 27
    }
}

21.
using System;

class OuterClass
{
    private int instanceVar = 10;
    protected static int protectedStaticVar = 20;

    private class InnerPrivateClass
    {
        public void AccessOuterInstance(OuterClass outer)
        {
            Console.WriteLine("Accessing private instanceVar: " + outer.instanceVar);
        }
    }

    protected class InnerProtectedClass
    {
        public static void AccessProtectedStatic()
        {
            Console.WriteLine("Accessing protected static variable: " + protectedStaticVar);
        }
    }

    public void TestAccess()
    {
        InnerPrivateClass inner = new InnerPrivateClass();
        inner.AccessOuterInstance(this);

        InnerProtectedClass.AccessProtectedStatic();
    }
}

class Program21
{
    static void Main()
    {
        OuterClass outer = new OuterClass();
        outer.TestAccess();
        
        OuterClass.InnerPrivateClass privateInner = new OuterClass.InnerPrivateClass();
        //In inaccessible due to its protection level
    }
}

22.
using System;

class BaseClass
{
    protected int protectedVar = 100;

    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected Internal Method in BaseClass");
    }

    public virtual void Display(string message = "Base Class")
    {
        Console.WriteLine("Message: " + message);
    }
}

class DerivedClass : BaseClass
{
    public override void Display(string message = "Derived Class")
    {
        Console.WriteLine("Overridden Message: " + message);
    }

    public void ShowProtectedVar()
    {
        Console.WriteLine("Protected Var from BaseClass: " + protectedVar);
        ProtectedInternalMethod();
    }
}

class Program22
{
    static void Main()
    {
        DerivedClass derived = new DerivedClass();
        derived.ShowProtectedVar();
        //Protected Var from BaseClass: 100
        //Protected Internal Method in BaseClass

        derived.Display();
        //Overridden Message: Derived Class
        
        BaseClass baseRef = derived;
        baseRef.Display("Called from BaseClass reference");
        //Overridden Message: Called from BaseClass reference
    }
}

23.
using System;

internal class InternalClass
{
    public static int Counter = 0;

    public static void IncrementCounter()
    {
        Counter++;
        Console.WriteLine("Counter incremented to: " + Counter);
    }

    public void ShowCounter()
    {
        Console.WriteLine("Counter: " + Counter);
    }
}

class Program23
{
    private InternalClass internalObj = new InternalClass();

    public void AccessInternalMembers()
    {
        InternalClass.IncrementCounter();
        internalObj.ShowCounter();
    }

    static void Main()
    {
        Program23 program = new Program23();
        program.AccessInternalMembers();
        // Counter incremented to: 1
        //Counter: 

        InternalClass.IncrementCounter();
        //Counter incremented to: 2
    }
}

24.
using System;

class BasePrivateProtected
{
    private protected int baseVar = 50;

    private protected void BaseMethod()
    {
        Console.WriteLine("BaseMethod called in BasePrivateProtected");
    }
}

class DerivedPrivateProtected : BasePrivateProtected
{
    public void AccessBaseMembers()
    {
        Console.WriteLine("Accessing baseVar in Derived: " + baseVar);
        BaseMethod();
    }

    private class NestedDerived
    {
        public void AttemptAccess(DerivedPrivateProtected derived)
        {
            Console.WriteLine("baseVar: " + derived.baseVar);
            
            derived.BaseMethod();
            
        }
    }
}

class Program24
{
    static void Main()
    {
        DerivedPrivateProtected derived = new DerivedPrivateProtected();
        derived.AccessBaseMembers();
        //Accessing baseVar in Derived: " 50
        //BaseMethod called in BasePrivateProtected
        
    }
}


25.
using System;

class BaseCalculator
{
    public static int Add(int a, int b) => a + b;

    private protected int Subtract(int a, int b) => a - b;
}

class AdvancedCalculator : BaseCalculator
{
    public void CalculateValues(ref int x, out int y)
    {
        y = Add(x, 10); // Using inherited public static method // 15
        x = Subtract(y, 5); // Using inherited private protected method //10
    }

    public static void Square(ref int x)
    {
        x *= x;
    }
}

class Program25
{
    static void Main()
    {
        int value = 5, result;
        AdvancedCalculator calculator = new AdvancedCalculator();

        calculator.CalculateValues(ref value, out result);
        Console.WriteLine($"Value after calculations: {value}, Result: {result}");
        //Value after calculations: 10, Result: 15

        AdvancedCalculator.Square(ref result);
        Console.WriteLine($"Square of Result: {result}");
        //Square of Result: 225
    }
}

26.
using System;

class Program26
{
    static int MultiplyByTwo(int number)
    {
        return number * 2;
    }

    static void Main()
    {
        int value = 5;
        int result = MultiplyByTwo(value);
        Console.WriteLine($"Original Value: {value}, After Multiplication: {result}");
        //Original Value: 5, After Multiplication: 10
    }
}

27.
using System;

class Rectangle
{
    public int Length { get; set; }
    public int Width { get; set; }
}

class Program27
{
    static Rectangle CreateRectangle(int length, int width)
    {
        return new Rectangle { Length = length, Width = width };
    }

    static void Main()
    {
        Rectangle rect = CreateRectangle(5, 10);
        Console.WriteLine($"Rectangle - Length: {rect.Length}, Width: {rect.Width}");
        //Rectangle - Length: 5, Width: 10
    }
}
28.
using System;

class Program28
{
    static int[] GenerateEvenNumbers(int count)
    {
        int[] evenNumbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            evenNumbers[i] = i * 2;
        }
        return evenNumbers;
    }

    static void Main()
    {
        int[] evens = GenerateEvenNumbers(5);
        Console.WriteLine("Generated Even Numbers:");
        foreach (int num in evens)
        {
            Console.WriteLine(num);
            //0,2,4,6,8
        }
    }
}

29.
using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program29
{
    static Person CreatePerson(string name, int age)
    {
        Person person = new Person { Name = name, Age = age };
        return person;
    }

    static void Main()
    {
        Person person = CreatePerson("Alice", 30);
        Console.WriteLine($"Person - Name: {person.Name}, Age: {person.Age}");
        //Person - Name: Alice, Age: 30

        Console.WriteLine($"Name in uppercase: {person.Name.ToUpper()}");
        //Name in uppercase: ALICE
    }
}

30.
using System;

class Calculator
{
    public int Number { get; set; }

    public int DoubleValue(int number)
    {
        return number * 2;
    }

    public Calculator IncreaseNumber(int increment)
    {
        Number += increment;
        return this;
    }
}

class Program30
{
    static void Main()
    {
        Calculator calc = new Calculator { Number = 10 };

        int doubled = calc.DoubleValue(5);
        Console.WriteLine("Doubled Value: " + doubled);
        //Doubled Value: 10

        Calculator updatedCalc = calc.IncreaseNumber(15);
        Console.WriteLine($"Original Calculator Number: {calc.Number}"); //25
        Console.WriteLine($"Returned Calculator Number: {updatedCalc.Number}"); //25

        Console.WriteLine("Are both references the same? " + (calc == updatedCalc)); //True
    }
}

31.
using System;

namespace Program31
{
    static class StringExtensions //ExtensionsClass
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    class Program
    {
        static void Main()
        {
            string message = "Hello World";
            string reversed = message.Reverse();
            Console.WriteLine("Reversed String: " + reversed);
            //Reversed String: dlroW olleH
        }
    }
}

32.
using System;

namespace Program32
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static class PersonExtensions
    {
        public static void DisplayInfo(this Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person { Name = "Alice", Age = 25 };
            
            p.DisplayInfo(); //Error

            PersonExtensions.DisplayInfo(p);
            //Name: Alice , Age: 25
 
        }
    }
}


33.

using System;

namespace Program33
{
    static class IntExtensions
    {
        public static void DoubleValue(this ref int number)
        {
            number *= 2;
        }
    }

    class Program
    {
        static void Main()
        {
            int value = 5;

            value.DoubleValue();

            Console.WriteLine("Value: " + value);
            
        }
    }
    //Value: 10
}

34.
using System;

namespace Program34
{
    class Calculator
    {
        public int Value { get; set; }
    }

    static class CalculatorExtensions
    {
        public static Calculator Add(this Calculator calc, int amount)
        {
            calc.Value += amount;
            return calc;
        }

        public static Calculator Multiply(this Calculator calc, int factor)
        {
            calc.Value *= factor;
            return calc;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator { Value = 10 };
            
            calc.Add(5).Multiply(3); //10+5=15 //15*3=45
            Console.WriteLine("Final Value: " + calc.Value);
            //Final Value: 45
        }
    }
}

35.

using System;

namespace Program35
{
    static class StringExtensions
    {
        public static bool IsValidEmail(this string str)
        {
            return str.Contains("@") && str.Contains(".") && str.IndexOf("@") < str.LastIndexOf(".");
        }

        public static string MaskEmail(this string str)
        {
            if (!str.IsValidEmail()) 
                return "Invalid email";

            int atIndex = str.IndexOf("@");
            return new string('*', atIndex) + str.Substring(atIndex);
        }
    }

    class Program
    {
        static void Main()
        {
            string email = "example@domain.com";
            Console.WriteLine("Is valid email: " + email.IsValidEmail());
            //Is valid email: True

            Console.WriteLine("Masked email: " + email.MaskEmail());
            //Masked email: *******@domain.com

            string invalidEmail = "invalid-email";
            Console.WriteLine("Masked invalid email: " + invalidEmail.MaskEmail());
            //Masked invalid email: Invalid email
        }
    }
}



