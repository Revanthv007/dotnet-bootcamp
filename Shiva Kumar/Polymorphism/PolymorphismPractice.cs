1)using System;

namespace MethodOverloadingExample {
    class NumberProcessor {
        public void Process(double number) { Console.WriteLine("Double overload called: " + number); }
        public void Process(float number) { Console.WriteLine("Float overload called: " + number); }
        public void Process(int number) { Console.WriteLine("Int overload called: " + number); }
    }

    class Program {
        static void Main() {
            NumberProcessor processor = new NumberProcessor();
            processor.Process(5);
            processor.Process(5.0f);
            processor.Process(5.0);
        }
    }
}


2)
using System;

namespace MethodHidingExample {
    class Animal {
        public void Speak() { Console.WriteLine("Animal speaks."); }
    }

    class Dog : Animal {
        public new void Speak() { Console.WriteLine("Dog barks."); }
    }

    class Program {
        static void Main() {
            Animal animal = new Dog();
            animal.Speak();
            Dog dog = new Dog();
            dog.Speak();
        }
    }
}

3)
using System;

namespace MethodOverloadingWithParams {
    class OverloadTest {
        public void Show(params int[] numbers) {
            Console.WriteLine("Called params overload");
            foreach (int num in numbers) Console.Write(num + " ");
            Console.WriteLine();
        }

        public void Show(int x, int y) {
            Console.WriteLine("Called fixed parameter overload");
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }

    class Program {
        static void Main() {
            OverloadTest test = new OverloadTest();
            test.Show(1, 2);
            test.Show(1, 2, 3);
        }
    }
}


4)using System;

namespace DisplayOverloadingExample {
    class DisplayOverload {
        public void Print(double x) { Console.WriteLine("Double overload: " + x); }
        public void Print(long x) { Console.WriteLine("Long overload: " + x); }
    }

    class Program {
        static void Main() {
            DisplayOverload display = new DisplayOverload();
            display.Print(10.5);
            display.Print(100L);
        }
    }
}

5)
using System;

namespace DefaultParameterExample {
    class Demo {
        public void Display(int x = 10) { Console.WriteLine("Single parameter: " + x); }
        public void Display(int x, int y = 20) { Console.WriteLine("Two parameters: " + x + ", " + y); }
    }

    class Program {
        static void Main() {
            Demo demo = new Demo();
            demo.Display();
            demo.Display(5);
            demo.Display(5, 30);
        }
    }
}

6)
using System;

namespace MethodOverridingExample {
    class Base {
        public virtual void Print() { Console.WriteLine("Base Print"); }
    }

    class Derived : Base {
        public override void Print() { Console.WriteLine("Derived Print"); }
    }

    class Program {
        static void Main() {
            Base derived = new Derived();
            derived.Print();
        }
    }
}

7)
using System;

namespace FieldHidingExample {
    class Parent {
        public int Value { get; set; } = 10;
    }

    class Child : Parent {
        public new int Value { get; set; } = 20;
    }

    class Program {
        static void Main() {
            Parent parent = new Child();
            Console.WriteLine("Parent value: " + parent.Value);
            Child child = new Child();
            Console.WriteLine("Child value: " + child.Value);
        }
    }
}

8)
using System;

namespace MultipleParameterOverloading {
    class Calculation {
        public void Sum(int x, int y, int z = 0) { Console.WriteLine("Sum with 3 parameters: " + (x + y + z)); }
        public void Sum(int x, int y) { Console.WriteLine("Sum with 2 parameters: " + (x + y)); }
    }

    class Program {
        static void Main() {
            Calculation calculation = new Calculation();
            calculation.Sum(5, 10);
            calculation.Sum(5, 10, 15);
        }
    }
}

9)using System;

namespace RefOutOverloadingExample {
    class RefOutOverloadingDemo {
        public void Process(int x) { Console.WriteLine("Process(int x) called: " + x); }
        public void Process(ref int x) { x *= 2; Console.WriteLine("Process(ref int x) called: " + x); }
        public void Process(out int x) { x = 100; Console.WriteLine("Process(out int x) called: " + x); }
    }

    class Program {
        static void Main() {
            RefOutOverloadingDemo refOutDemo = new RefOutOverloadingDemo();
            int x = 10;
            refOutDemo.Process(x);
            refOutDemo.Process(ref x);
            int y;
            refOutDemo.Process(out y);
        }
    }
}

10)
using System;

namespace ComplexOverloadingStringObject {
    class Printer {
        public void Print(string message) { Console.WriteLine("String overload: " + message); }
        public void Print(object message) { Console.WriteLine("Object overload: " + message); }
    }

    class Program {
        static void Main() {
            Printer printer = new Printer();
            printer.Print("Hello");
            printer.Print(123);
        }
    }
}

11)
using System;

namespace MethodHidingWithMultipleClasses {
    class Animal {
        public void Speak() { Console.WriteLine("Animal speaks."); }
    }

    class Dog : Animal {
        public new void Speak() { Console.WriteLine("Dog barks."); }
    }

    class Cat : Animal {
        public new void Speak() { Console.WriteLine("Cat meows."); }
    }

    class Bird : Animal {
        public new void Speak() { Console.WriteLine("Bird chirps."); }
    }

    class Program {
        static void Main() {
            Animal animal = new Dog();
            animal.Speak(); // Dog barks

            animal = new Cat();
            animal.Speak(); // Cat meows

            animal = new Bird();
            animal.Speak(); // Bird chirps

            Dog dog = new Dog();
            dog.Speak(); // Dog barks
        }
    }
}

12)using System;

namespace AmbiguousOverloadingWithMultipleParams {
    class Calculator {
        public void Add(int a, int b) { Console.WriteLine($"Sum of integers: {a + b}"); }
        public void Add(float a, float b) { Console.WriteLine($"Sum of floats: {a + b}"); }
        public void Add(double a, double b) { Console.WriteLine($"Sum of doubles: {a + b}"); }
    }

    class ExtendedCalculator : Calculator {
        public void Add(int a, int b, int c) { Console.WriteLine($"Sum of 3 integers: {a + b + c}"); }
        public void Add(float a, float b, float c) { Console.WriteLine($"Sum of 3 floats: {a + b + c}"); }
        public void Add(double a, double b, double c) { Console.WriteLine($"Sum of 3 doubles: {a + b + c}"); }
    }

    class Program {
        static void Main() {
            ExtendedCalculator calculator = new ExtendedCalculator();
            calculator.Add(1, 2);
            calculator.Add(1.5f, 2.5f);
            calculator.Add(10.5, 20.5);
            calculator.Add(1, 2, 3);
        }
    }
}

13)
using System;

namespace StaticMethodHidingWithInheritance {
    class Base {
        public static void Display() { Console.WriteLine("Base static Display called."); }
    }

    class Derived : Base {
        public new static void Display() { Console.WriteLine("Derived static Display called."); }
    }

    class FurtherDerived : Derived {
        public new static void Display() { Console.WriteLine("FurtherDerived static Display called."); }
    }

    class Program {
        static void Main() {
            Base.Display(); // Base static Display called
            Derived.Display(); // Derived static Display called
            FurtherDerived.Display(); // FurtherDerived static Display called

            Base baseObj = new Derived();
            baseObj.Display(); // Base static Display called (static methods cannot be overridden, so it's still Base method)

            Derived derivedObj = new FurtherDerived();
            derivedObj.Display(); // FurtherDerived static Display called
        }
    }
}

14)using System;

namespace MethodOverloadingWithMultipleClasses {
    class Vehicle {
        public void Start() { Console.WriteLine("Vehicle started"); }
        public void Stop() { Console.WriteLine("Vehicle stopped"); }
    }

    class Car : Vehicle {
        public void Start(int speed) { Console.WriteLine($"Car started at {speed} km/h"); }
        public void Stop(int speed) { Console.WriteLine($"Car stopped at {speed} km/h"); }
    }

    class Bike : Vehicle {
        public void Start(string type) { Console.WriteLine($"Bike started: {type}"); }
        public void Stop(string type) { Console.WriteLine($"Bike stopped: {type}"); }
    }

    class Program {
        static void Main() {
            Vehicle vehicle = new Car();
            vehicle.Start(); // Vehicle started
            vehicle.Stop(); // Vehicle stopped

            Car car = new Car();
            car.Start(80); // Car started at 80 km/h
            car.Stop(40); // Car stopped at 40 km/h

            Bike bike = new Bike();
            bike.Start("Mountain Bike"); // Bike started: Mountain Bike
            bike.Stop("Road Bike"); // Bike stopped: Road Bike
        }
    }
}

15)
using System;

namespace ComplexInheritanceAndMethodHiding {
    class Animal {
        public virtual void Speak() { Console.WriteLine("Animal speaks"); }
    }

    class Dog : Animal {
        public override void Speak() { Console.WriteLine("Dog barks"); }
    }

    class Cat : Animal {
        public override void Speak() { Console.WriteLine("Cat meows"); }
    }

    class Bird : Animal {
        public override void Speak() { Console.WriteLine("Bird chirps"); }
    }

    class AnimalTrainer {
        public void Train(Animal animal) { 
            animal.Speak();
        }
    }

    class Program {
        static void Main() {
            AnimalTrainer trainer = new AnimalTrainer();

            Animal dog = new Dog();
            trainer.Train(dog); // Dog barks

            Animal cat = new Cat();
            trainer.Train(cat); // Cat meows

            Animal bird = new Bird();
            trainer.Train(bird); // Bird chirps

            Animal genericAnimal = new Animal();
            trainer.Train(genericAnimal); // Animal speaks
        }
    }
}

16)
using System;

namespace BankingSystem {
    class Account {
        public double Balance { get; protected set; }

        public Account(double initialBalance) {
            Balance = initialBalance;
        }

        public virtual void Deposit(double amount) {
            if (amount > 0) {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
            } else {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public virtual void Withdraw(double amount) {
            if (amount > 0 && amount <= Balance) {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}, New Balance: {Balance}");
            } else {
                Console.WriteLine("Invalid withdrawal.");
            }
        }
    }

    class SavingsAccount : Account {
        private double interestRate;

        public SavingsAccount(double initialBalance, double rate) : base(initialBalance) {
            interestRate = rate;
        }

        public void AddInterest() {
            double interest = Balance * interestRate;
            Deposit(interest);
            Console.WriteLine($"Interest added: {interest}, New Balance: {Balance}");
        }
    }

    class CheckingAccount : Account {
        public CheckingAccount(double initialBalance) : base(initialBalance) {}

        public override void Withdraw(double amount) {
            if (amount > 0 && amount <= Balance + 1000) { // Allow overdraft of $1000
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}, New Balance: {Balance}");
            } else {
                Console.WriteLine("Insufficient funds or overdraft limit exceeded.");
            }
        }
    }

    class Program {
        static void Main() {
            Account savings = new SavingsAccount(5000, 0.03);
            savings.Deposit(200);
            savings.Withdraw(1000);
            ((SavingsAccount)savings).AddInterest();

            Account checking = new CheckingAccount(2000);
            checking.Deposit(500);
            checking.Withdraw(2500);
            checking.Withdraw(4000); // Overdraft allowed
        }
    }
}

17)
using System;

namespace ECommerceSystem {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual void DisplayInfo() {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }
    }

    class DigitalProduct : Product {
        public string DownloadLink { get; set; }

        public DigitalProduct(string name, double price, string downloadLink)
            : base(name, price) {
            DownloadLink = downloadLink;
        }

        public override void DisplayInfo() {
            base.DisplayInfo();
            Console.WriteLine($"Download Link: {DownloadLink}");
        }
    }

    class PhysicalProduct : Product {
        public double ShippingCost { get; set; }

        public PhysicalProduct(string name, double price, double shippingCost)
            : base(name, price) {
            ShippingCost = shippingCost;
        }

        public override void DisplayInfo() {
            base.DisplayInfo();
            Console.WriteLine($"Shipping Cost: {ShippingCost}");
        }
    }

    class Program {
        static void Main() {
            Product digitalProduct = new DigitalProduct("E-Book", 10.99, "www.downloadlink.com");
            Product physicalProduct = new PhysicalProduct("Laptop", 1000.00, 50.00);

            digitalProduct.DisplayInfo();
            physicalProduct.DisplayInfo();
        }
    }
}

18)
using System;

namespace OnlineStore {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual void DisplayInfo() {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }

        public double ApplyDiscount(double discountPercentage) {
            return Price - (Price * discountPercentage / 100);
        }
    }

    class Clothing : Product {
        public string Size { get; set; }

        public Clothing(string name, double price, string size) : base(name, price) {
            Size = size;
        }

        public override void DisplayInfo() {
            base.DisplayInfo();
            Console.WriteLine($"Size: {Size}");
        }
    }

    class Electronics : Product {
        public int WarrantyPeriod { get; set; }

        public Electronics(string name, double price, int warrantyPeriod) : base(name, price) {
            WarrantyPeriod = warrantyPeriod;
        }

        public override void DisplayInfo() {
            base.DisplayInfo();
            Console.WriteLine($"Warranty Period: {WarrantyPeriod} years");
        }
    }

    class Program {
        static void Main() {
            Product shirt = new Clothing("T-Shirt", 19.99, "L");
            Product phone = new Electronics("Smartphone", 799.99, 2);

            shirt.DisplayInfo();
            phone.DisplayInfo();

            double discountedPrice = shirt.ApplyDiscount(10);
            Console.WriteLine($"Discounted Price: {discountedPrice}");

            discountedPrice = phone.ApplyDiscount(5);
            Console.WriteLine($"Discounted Price: {discountedPrice}");
        }
    }
}


