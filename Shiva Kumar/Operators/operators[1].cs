//1
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 3;
        Console.WriteLine("Addition: " + (a + b)); 
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));
    }
}
/*
Addition: 13
Subtraction: 7
Multiplication: 30
Division: 3
Modulus: 1
*/

//2

class Program
{
    static void Main()
    {
        float x = 7.5f;
        float y = 2.5f;
        Console.WriteLine("Addition: " + (x + y));
        Console.WriteLine("Subtraction: " + (x - y));
        Console.WriteLine("Multiplication: " + (x * y));
        Console.WriteLine("Division: " + (x / y));
        Console.WriteLine("Modulus: " + (x % y));
    }
}
/*
Addition: 10
Subtraction: 5
Multiplication: 18.75
Division: 3
Modulus: 0
*/

//3
class Program
{
    static void Main()
    {
        double a = 10.5;
        double b = 3.5;
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));
    }
}/*
Addition: 14
Subtraction: 7
Multiplication: 36.75
Division: 3
Modulus: 0
*/

//4
class Program
{
    static void Main()
    {
        decimal x = 10.5m;
        decimal y = 3.5m;
        Console.WriteLine("Addition: " + (x + y));
        Console.WriteLine("Subtraction: " + (x - y));
        Console.WriteLine("Multiplication: " + (x * y));
        Console.WriteLine("Division: " + (x / y));
        Console.WriteLine("Modulus: " + (x % y));
    }
}

/*
Addition: 14.0
Subtraction: 7.0
Multiplication: 36.75
Division: 3.0
Modulus: 0.0
*/
//5

class Program
{
    static void Main()
    {
        int num = 5;
        int a = num++;
        int b = ++num;
        int c = num--;
        int d = --num;
        Console.WriteLine($"Increment after: {a}, Increment before: {b}");
        Console.WriteLine($"Decrement after: {c}, Decrement before: {d}");
        Console.WriteLine($"Final value: {num}");
    }
}

/*
Increment after: 5, Increment before: 7
Decrement after: 7, Decrement before: 5
Final value: 5
*/
//6

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;
        int result = a + b * 2 - 3 / 2;
        Console.WriteLine("Result: " + result);
    }
}

// Result: 19

//7
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;
        int result = (a + b) * 2 - 3 / 2;
        Console.WriteLine("Result: " + result);
    }
}
// Result: 29

//8
class Program
{
    static void Main()
    {
        // Initialize variables
        int baseValue = 100;
        int modifier = 7;
        int divisor = 3;

        // Create an array to store results
        int[] results = new int[5];

        // Perform operations and store results
        results[0] = baseValue += modifier;  // Addition assignment
        results[1] = baseValue -= modifier;  // Subtraction assignment
        results[2] = baseValue *= modifier;  // Multiplication assignment
        results[3] = baseValue /= divisor;   // Division assignment
        results[4] = baseValue %= divisor;   // Modulus assignment

        // Display results
        Console.WriteLine("Results of compound operations:");
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"Operation {i + 1}: {results[i]}");
        }

        // Perform a complex calculation using all operators
        int complexResult = 50;
        complexResult += 10;
        complexResult *= 3;
        complexResult -= 25;
        complexResult /= 5;
        complexResult %= 7;

        Console.WriteLine($"\nResult of complex calculation: {complexResult}");

        // Demonstrate operator precedence
        int precedenceResult = 10 + 5 * 2 - 8 / 4 % 3;
        Console.WriteLine($"\nResult demonstrating operator precedence: {precedenceResult}");
    }
}
/*
Results of compound operations:
Operation 1: 107
Operation 2: 100
Operation 3: 700
Operation 4: 233
Operation 5: 2

Result of complex calculation: 3

Result demonstrating operator precedence: 18

*/

//9
class Program
{
    static void Main()
    {
        int result = 10;
        result += 5;
        result -= 3;
        result *= 2;
        result /= 4;
        result %= 5;
        Console.WriteLine("Result after compound operations: " + result);
    }
}
// Result after compound operations: 1

//10
class Program
{
    static void Main()
    {
        int x = 15, y = 5, z = 3;
        int result = (x * y + z) / z - y % z;
        Console.WriteLine("Result of complex expression: " + result);
    }
}
//Result of complex expression: 24


//11
class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        int result = a + b * 2 - 3 / 2;
        Console.WriteLine("Result: " + result);
    }
}
//Result: 19



//12
class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        int result = (a + b) * 2 - 3 / 2;
        Console.WriteLine("Result: " + result);
    }
}

//Result: 29

//13
class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        int result = a + b * 2 - 3 / 2;
        Console.WriteLine("Result: " + result);
    }
}
//Result: 19

//14
class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        int result = (a + b) * 2 - 3 / 2;
        Console.WriteLine("Result: " + result);
    }
}
//Result: 29

//15
class Program
{
    static void Main()
    {
        double a = 9.5, b = 4.5;
        double result = Math.Pow(a, 2) + Math.Sqrt(b) - Math.Sin(a);
        Console.WriteLine("Result with Math functions: " + result);
    }
}
//Result with Math functions: 92.75910297914


//16
class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
        Console.WriteLine("a >= b: " + (a >= b));
        Console.WriteLine("a <= b: " + (a <= b));
    }
}
/*
a > b: True
a < b: False
a == b: False
a != b: True
a >= b: True
a <= b: False
*/

//17
class Program
{
    static void Main()
    {
        float a = 10.5f, b = 5.5f;
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
        Console.WriteLine("a >= b: " + (a >= b));
        Console.WriteLine("a <= b: " + (a <= b));
    }
}
/*
a > b: True
a < b: False
a == b: False
a != b: True
a >= b: True
a <= b: False

*/
//18
class Program
{
    static void Main()
    {
        float x = 3.5f, y = 3.5f;
        Console.WriteLine("x == y: " + (x == y));
        Console.WriteLine("x != y: " + (x != y));
        Console.WriteLine("x >= y: " + (x >= y));
        Console.WriteLine("x <= y: " + (x <= y));
    }
}

/*
x == y: True
x != y: False
x >= y: True
x <= y: True
*/ 

//19
class Program
{
    static void Main()
    {
        int age = 20;
        if (age >= 18)
            Console.WriteLine("Eligible to vote");
        else
            Console.WriteLine("Not eligible to vote");
    }
}
//Eligible to vote

//20
class Program
{
    static void Main()
    {
        int score = 75;
        if (score >= 50 && score <= 100)
            Console.WriteLine("Passed");
        else
            Console.WriteLine("Failed");
    }
}
//Passed

//21
class Program
{
    static void Main()
    {
        int num = 10;
        if (num % 2 == 0)
            Console.WriteLine("Even number");
        else
            Console.WriteLine("Odd number");
    }
}
//Even number

//22
class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        bool result = (a > b) && (a % 2 == 0);
        Console.WriteLine("Logical AND result: " + result);
    }
}
//Logical AND result: true

//23
class Program
{
    static void Main()
    {
        int x = 10, y = 20, z = 15;
        bool result = (x < y) && (y > z) && (x != z);
        Console.WriteLine("Complex relational result: " + result);
    }
}
// Complex relational result: true

//24
class Program
{
    static void Main()
    {
        int[] arr = { 2, 4, 6, 8 };
        bool found = arr.Length > 0 && arr[0] < arr[arr.Length - 1];
        Console.WriteLine("First element < Last element: " + found);
    }
}
// First element < Last element: true

//25
using System;
class Program
{
    static void Main()
    {
        // Arithmetic operations
        int x = 10, y = 5, z = 3;
        int result1 = (x * y + z) / z - y % z;
        Console.WriteLine("Result of (x * y + z) / z - y % z: " + result1);

        // Operator precedence
        int a = 10, b = 5;
        int result2 = a + b * 2 - 3 / 2;
        Console.WriteLine("Result of a + b * 2 - 3 / 2: " + result2);

        int result3 = (a + b) * 2 - 3 / 2;
        Console.WriteLine("Result of (a + b) * 2 - 3 / 2: " + result3);

        // Relational operations
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
        Console.WriteLine("a >= b: " + (a >= b));
        Console.WriteLine("a <= b: " + (a <= b));

        // Complex relational expression
        int x1 = 10, y1 = 20, z1 = 15;
        bool result4 = (x1 < y1) && (y1 > z1) && (x1 != z1);
        Console.WriteLine("Complex relational result: " + result4);

        // Operator precedence with relational and arithmetic operations
        int num1 = 10, num2 = 5, num3 = 3;
        bool result5 = (num1 > num2) && (num1 % 2 == 0);
        Console.WriteLine("Logical AND result: " + result5);

        int result6 = num1 + num2 * num3 - 2 / 2;
        Console.WriteLine("Result of num1 + num2 * num3 - 2 / 2: " + result6);

        int result7 = (num1 + num2) * num3 - 2 / 2;
        Console.WriteLine("Result of (num1 + num2) * num3 - 2 / 2: " + result7);
    }
}
/*
Result of (x * y + z) / z - y % z: 15
Result of a + b * 2 - 3 / 2: 19
Result of (a + b) * 2 - 3 / 2: 29
a > b: True
a < b: False
a == b: False
a != b: True
a >= b: True
a <= b: False
Complex relational result: True
Logical AND result: True
Result of num1 + num2 * num3 - 2 / 2: 24
Result of (num1 + num2) * num3 - 2 / 2: 44
*/
//26
#Logical Operators Programs
class Program
{
    static void Main()
    {
        int x = 10, y = 5, z = 3;
        bool result1 = (x > y) && (y > z);
        Console.WriteLine("Logical AND result: " + result1);

        bool result2 = (x > y) || (y < z);
        Console.WriteLine("Logical OR result: " + result2);

        bool result3 = !(x > y);
        Console.WriteLine("Logical NOT result: " + result3);

        bool result4 = (x > y) && (y > z) && (x != z);
        Console.WriteLine("Complex logical result: " + result4);

        bool result5 = (x > y) && (y > z) || (x == z);
        Console.WriteLine("Complex logical result with OR: " + result5);

        bool result6 = !(x > y) && (y > z) || (x == z);
        Console.WriteLine("Complex logical result with NOT and OR: " + result6);
    }
}
//27
/*
Logical AND result: True
Logical OR result: True
Logical NOT result: False
Complex logical result: True
Complex logical result with OR: True
Complex logical result with NOT and OR: False
*/
using System;
class Program
{
    static void Main()
    {
        int num = 15;
        bool isBetween10And20 = num >= 10 && num <= 20;
        Console.WriteLine($"Number is between 10 and 20: {isBetween10And20}");
    }
}
//Number is between 10 and 20: true

//28
using System;
class Program
{
    
    static void Main()
    {
        int num1 = -5, num2 = 10;
        bool isPositive = num1 > 0 || num2 > 0;
        Console.WriteLine($"At least one number is positive: {isPositive}");
    }
}
//At least one number is positive: true

//29
using System;

class Program
{
    static void Main()
    {
        int num1 = 5, num2 = 10;
        bool result = (num1 > 0 && num2 > 0) && !(num1 == num2);
        Console.WriteLine($"Both numbers are positive and not equal: {result}");
    }
}
//Both numbers are positive and not equal: true

//30
using System;

class Program
{
    static void Main()
    {
        int age = 20;
        bool canVote = age >= 18;
        bool canDrive = age >= 16;
        bool canVoteAndDrive = canVote && canDrive;
        bool cannotDoEither = !canVote || !canDrive;

        Console.WriteLine($"Can vote and drive: {canVoteAndDrive}");
        Console.WriteLine($"Cannot do either: {cannotDoEither}");
    }
}
//Can vote and drive: true
//Cannot do either: false

//31
using System;
class Program
{
    static void Main()
    {
        int year = 2024;
        int divisor = 4;
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        bool divisibleByDivisor = year % divisor == 0;
        bool result = isLeapYear && divisibleByDivisor;

        Console.WriteLine($"Year is a leap year and divisible by {divisor}: {result}");
    }
}
//Year is a leap year and divisible by 4: True

//32
using System;
class Program
{
    static void Main()
    {
        string username = "admin";
        string password = "secure";
        bool isAdmin = username == "admin" && password == "secure";
        bool isGuest = username == "guest" || password == "guest123";
        bool accessGranted = isAdmin || isGuest;

        Console.WriteLine($"Access granted: {accessGranted}");
    }
}
//Access granted: True

// #Bitwise Operators Programs
// Logical Operators Programs
// Logical Operators in C# include:
// && (Logical AND)
// || (Logical OR)
// ! (Logical NOT)
// These operators evaluate conditions and return a Boolean result (true or false).

//33
class Program
{
    static void Main()
    {
        int num = 15;
        bool isBetween10And20 = num >= 10 && num <= 20;
        Console.WriteLine($"Number is between 10 and 20: {isBetween10And20}");
    }
}
//Number is between 10 and 20: true

//34
class Program
{
    static void Main()
    {
        int num1 = -5, num2 = 10;
        bool isPositive = num1 > 0 || num2 > 0;
        Console.WriteLine($"At least one number is positive: {isPositive}");
    }
}
//At least one number is positive: true

//35
class Program
{
    static void Main()
    {
        int num1 = 5, num2 = 10;
        bool result = (num1 > 0 && num2 > 0) && !(num1 == num2);
        Console.WriteLine($"Both numbers are positive and not equal: {result}");
    }
}
//Both numbers are positive and not equal: true

//36
class Program
{
    static void Main()
    {
        int age = 20;
        bool canVote = age >= 18;
        bool canDrive = age >= 16;
        bool canVoteAndDrive = canVote && canDrive;
        bool cannotDoEither = !canVote || !canDrive;

        Console.WriteLine($"Can vote and drive: {canVoteAndDrive}");
        Console.WriteLine($"Cannot do either: {cannotDoEither}");
    }
}
//Can vote and drive: true
//Cannot do either: false

//37
class Program
{
    static void Main()
    {
        int year = 2024;
        int divisor = 4;
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        bool divisibleByDivisor = year % divisor == 0;
        bool result = isLeapYear && divisibleByDivisor;

        Console.WriteLine($"Year is a leap year and divisible by {divisor}: {result}");
    }
}
//Year is a leap year and divisible by 4: True

//38
class Program
{
    static void Main()
    {
        string username = "admin";
        string password = "secure";
        bool isAdmin = username == "admin" && password == "secure";
        bool isGuest = username == "guest" || password == "guest123";
        bool accessGranted = isAdmin || isGuest;

        Console.WriteLine($"Access granted: {accessGranted}");
    }
}
// Access granted: true

/*Bitwise Operators in C# include:
& (Bitwise AND)
| (Bitwise OR)
^ (Bitwise XOR)
~ (Bitwise NOT)
<< (Left Shift)
>> (Right Shift)
These operators perform operations on individual bits of integers.
*/
//39
using System;

class Program
{
    static void Main()
    {
        int a = 6; // 110 in binary
        int b = 3; // 011 in binary
        Console.WriteLine($"a & b: {a & b}"); // 010 -> 2
        Console.WriteLine($"a | b: {a | b}"); // 111 -> 7
        Console.WriteLine($"a ^ b: {a ^ b}"); // 101 -> 5
    }
}
/*
a & b: 2
a | b: 7
a ^ b: 5
*/

//40
class Program
{
    static void Main()
    {
        int a = 5; // 00000101 in binary
        Console.WriteLine($"~a: {~a}"); // Should give the bitwise NOT result
    }
}
// ~a: -6


//41
class Program
{
    static void Main()
    {
        int num = 7;
        bool isOdd = (num & 1) == 1;
        Console.WriteLine($"Number is odd: {isOdd}");
    }
}
// Number is odd: true


//42
class Program
{
    static void Main()
    {
        int num = 4;
        int multiplied = num << 2; // 4 * 4 = 16
        int divided = num >> 1;    // 4 / 2 = 2
        Console.WriteLine($"Multiplied by 4 using <<: {multiplied}");
        Console.WriteLine($"Divided by 2 using >>: {divided}");
    }
}
// Multiplied by 4 using <<: 16
//  Divided by 2 using >>: 2

//43
class Program
{
    static void Main()
    {
        int a = 5, b = 3;
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
        Console.WriteLine($"After swap: a = {a}, b = {b}");
    }
}
// After swap: a = 3, b = 5


//44
class Program
{
    static void Main()
    {
        int num = 13; // 1101 in binary
        int count = 0;
        while (num != 0)
        {
            count += num & 1;
            num >>= 1;
        }
        Console.WriteLine($"Number of set bits: {count}");
    }
}
// Number of set bits: 3

//45
class Program
{
    static void Main()
    {
        int num = 13; // 1101 in binary
        int count = 0;
        while (num != 0)
        {
            count += num & 1;
            num >>= 1;
        }
        Console.WriteLine($"Number of set bits: {count}");
    }
}
// Number of set bits: 3

//46
class Program
{
    static void Main()
    {
        Console.WriteLine("Bitwise and Logical Operators Challenge");
        Console.WriteLine("---------------------------------------");

        int a = 60;  // 0011 1100 in binary
        int b = 13;  // 0000 1101 in binary

        // Bitwise operatio ns
        int c = a & b;  // Bitwise AND  //12
        int d = a | b;  // Bitwise OR   //61 
        int e = a ^ b;  // Bitwise XOR  //49
        int f = ~a;     // Bitwise NOT

        Console.WriteLine($"a = {a} ({Convert.ToString(a, 2).PadLeft(8, '0')})");  a = 60 (0011 1100)
        Console.WriteLine($"b = {b} ({Convert.ToString(b, 2).PadLeft(8, '0')})");  b = 13 (0000 1101)
        Console.WriteLine($"a & b = {c} ({Convert.ToString(c, 2).PadLeft(8, '0')})");
        Console.WriteLine($"a | b = {d} ({Convert.ToString(d, 2).PadLeft(8, '0')})");
        Console.WriteLine($"a ^ b = {e} ({Convert.ToString(e, 2).PadLeft(8, '0')})");
        Console.WriteLine($"~a = {f} ({Convert.ToString(f, 2).PadLeft(32, '0')})");

        // Shift operations
        int left = a << 2;   // Left shift  //240
        int right = a >> 2;  // Right shift  // 15

        Console.WriteLine($"a << 2 = {left} ({Convert.ToString(left, 2).PadLeft(8, '0')})"); // a << 2 = 240 (1111 0000)
        Console.WriteLine($"a >> 2 = {right} ({Convert.ToString(right, 2).PadLeft(8, '0')})"); // a >> 2 =15 (0000 1111)

        // Tricky part: Combining bitwise and logical operators
	int a = 60;  // 0011 1100 in binary
        int b = 13;  // 0000 1101 in binary

        bool result1 = (a & b) != 0 && (a | b) > 0; //true
        bool result2 = (a ^ b) > (a & b) || (a | b) < (a ^ b); //true
        bool result3 = ((a << 2) > (b >> 1)) && ((a | b) > (a & b)); //true

        Console.WriteLine("\nTricky Combinations:");
        Console.WriteLine($"(a & b) != 0 && (a | b) > 0: {result1}");
        Console.WriteLine($"(a ^ b) > (a & b) || (a | b) < (a ^ b): {result2}");
        Console.WriteLine($"((a << 2) > (b >> 1)) && ((a | b) > (a & b)): {result3}");

        // Even trickier: Bit counting and manipulation
        int setBitsInA = CountSetBits(a); //4
        int setBitsInB = CountSetBits(b); // 3
        bool moreBitsSet = setBitsInA > setBitsInB; //true

        Console.WriteLine($"\nSet bits in a: {setBitsInA}"); //4
        Console.WriteLine($"Set bits in b: {setBitsInB}"); //3
        Console.WriteLine($"a has more set bits than b: {moreBitsSet}"); //true

        // Final challenge: Combine everything
        bool finalResult = ((a & b) << 2) > ((a | b) >> 1) && CountSetBits(a ^ b) >= CountSetBits(a & b); //true
        Console.WriteLine($"\nFinal challenge result: {finalResult}");
    }

    static int CountSetBits(int n)
    {
        int count = 0;
        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
}
/*
Bitwise and Logical Operators Challenge
---------------------------------------
a = 60 (00111100)
b = 13 (00001101)
a & b = 12 (00001100)
a | b = 61 (00111101)
a ^ b = 49 (00110001)
~a = -61 (11111111111111111111111111000011)
a << 2 = 240 (11110000)
a >> 2 = 15 (00001111)

Tricky Combinations:
(a & b) != 0 && (a | b) > 0: True
(a ^ b) > (a & b) || (a | b) < (a ^ b): True
((a << 2) > (b >> 1)) && ((a | b) > (a & b)): True

Set bits in a: 4
Set bits in b: 3
a has more set bits than b: True

Final challenge result: True
*/


//47
class Program
{
    static void Main()
    {
        int a = 10;
        Console.WriteLine($"Initial value of a: {a}");

        a += 5;
        Console.WriteLine($"After a += 5: {a}");

        a -= 3;
        Console.WriteLine($"After a -= 3: {a}");

        a *= 2;
        Console.WriteLine($"After a *= 2: {a}");

        a /= 4;
        Console.WriteLine($"After a /= 4: {a}");

        a %= 3;
        Console.WriteLine($"After a %= 3: {a}");

        a &= 5;
        Console.WriteLine($"After a &= 5: {a}");

        a |= 2;
        Console.WriteLine($"After a |= 2: {a}");

        a ^= 3;
        Console.WriteLine($"After a ^= 3: {a}");

        a <<= 2;
        Console.WriteLine($"After a <<= 2: {a}");

        a >>= 1;
        Console.WriteLine($"After a >>= 1: {a}");


        int x = 10;
        x += 5;
        Console.WriteLine(x);
        x -= 3;
        Console.WriteLine(x);
        x *= 2;
        Console.WriteLine(x);
        x /= 4;
        Console.WriteLine(x);
        x %= 5;
        Console.WriteLine(x);


        float y = 8.5f;
        y += 2.5f;
        Console.WriteLine(y);
        y -= 1.0f;
        Console.WriteLine(y);
        y *= 3.0f;
        Console.WriteLine(y);
        y /= 2.0f;
        Console.WriteLine(y);
        y %= 7.0f;
        Console.WriteLine(y);

        string text = "Hello";
        Console.WriteLine(text);
        text += ", ";
        Console.WriteLine(text);
        text += "iConnect";
        Console.WriteLine(text);
        text += "!";
        Console.WriteLine(text);

        int[] numbers = { 2, 4, 6, 8 };
        numbers[0] += 10;
        numbers[1] *= 2;
        numbers[2] -= 3;
        numbers[3] /= 2;
        Console.WriteLine(string.Join(", ", numbers));

        int value = 5;
        for (int i = 0; i < 3; i++)
        {
            value += 5;
            value *= 2;
        }
        Console.WriteLine(value);

        int z = 14;      // binary: 1110
        z &= 11;         // z = z & 11 (binary 1011) => z = 10 (binary 1010)
        z |= 3;          // z = z | 3 (binary 0011) => z = 11 (binary 1011)
        z ^= 6;          // z = z ^ 6 (binary 0110) => z = 13 (binary 1101)
        Console.WriteLine(z);

    }
}
/*
Initial value of a: 10
After a += 5: 15
After a -= 3: 12
After a *= 2: 24
After a /= 4: 6
After a %= 3: 0
After a &= 5: 0
After a |= 2: 2
After a ^= 3: 1
After a <<= 2: 4
After a >>= 1: 2
15
12
24
6
1
11
10
30
15
1
Hello
Hello,
Hello, iConnect
Hello, iConnect!
12, 8, 3, 4
110
13
*/

//48
#Conditional (Ternary) Operators

class Program
{
    static void Main()
    {
        int a = 5;
        int result = (a > 3) ? a : 0;
        Console.WriteLine(result);

        string name = "Alice";
        string greeting = (name == "Alice") ? "Hello, Alice!" : "Who are you?";
        Console.WriteLine(greeting);

        int age = 20;
        string category = (age < 13) ? "Child" : (age < 18) ? "Teen" : "Adult";
        Console.WriteLine(category);

        int number = 9;
        string type = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine(type);

        int score = 85;
        string grade = (score >= 90) ? "A" : (score >= 80) ? "B" : (score >= 70) ? "C" : "F";
        Console.WriteLine(grade);

        int marks = 76;
        string result = (marks >= 50) ? (marks >= 75 ? "Pass with Honors" : "Pass") : "Fail";
        Console.WriteLine(result);
    }
}
5
// Hello, Alice!
// Adult
// Odd
// B
// Pass with Honors

#Null-Coalescing Operators

//49
class Program1
{
    static void Main()
    {
        string name = null;
        string displayName = name ?? "Guest";
        Console.WriteLine($"Hello, {displayName}!");

        int? number = null;
        int defaultValue = number ?? 100;
        Console.WriteLine($"The value is: {defaultValue}");

        string[] words = null;
        int? wordCount = words?.Length;
        Console.WriteLine($"Word count: {wordCount}");

         Person person = null;
        string city = person?.Address?.City;
        Console.WriteLine($"City: {city}");

        Order order = null;
        string product = order?.Product?.Category?.ToUpper();
        Console.WriteLine($"Product Category: {product}");


    }
}
class Person
{
    public Address Address { get; set; }
}

class Address
{
    public string City { get; set; }
}

class Order
{
    public Product Product { get; set; }
}

class Product
{
    public string Category { get; set; }
}

/*
Hello, Guest!
The value is: 100
Word count:
City:
Product Category:
*/

//50
class Program
{
    static void Main()
    {
        string name = null;
        string result = name ?? "Guest";
        Console.WriteLine(result);

        int? age = null;
        int finalAge = age ?? 18;
        Console.WriteLine(finalAge);

        string username = null;
        string displayName = username ?? "Anonymous";
        Console.WriteLine(displayName);

        int? score = null;
        int finalScore = score ?? 0;
        Console.WriteLine(finalScore);

        string input = null;
        string message = input ?? "No input provided";
        Console.WriteLine(message);

        int? value = null;
        int finalValue = value ?? 42;
        Console.WriteLine(finalValue);

        string text = null;
        string output = text ?? "Empty string";
        Console.WriteLine(output);

        int? number = null;
        int finalNumber = number ?? 99;
        Console.WriteLine(finalNumber);

        string data = null;
        string result = data ?? "No data available";
        Console.WriteLine(result);

        int? points = null;
        int finalPoints = points ?? 0;
        Console.WriteLine(finalPoints);
    }
}
/*
Guest
18
Anonymous
0
No input provided
42
Empty string
99
No data available
0
*/


//51
using System;

class Program
{
    static void Main(string[] args)
    {
        // Null-Coalescing Operators
        string value1 = null;
        string value2 = "Default Value";
        string result1 = value1 ?? value2;
        Console.WriteLine(result1);

        string value3 = null;
        string result2 = value3 ?? value2 ?? "Fallback Value";
        Console.WriteLine(result2);

        string value4 = "Value A";
        string result3 = value4 ?? value2 ?? "Fallback Value";
        Console.WriteLine(result3);

        string value5 = null;
        string result4 = (value5 ?? value3) ?? "Final Default Value";
        Console.WriteLine(result4);

        string value6 = null;
        string value7 = null;
        string result5 = value6 ?? value7 ?? value2 ?? "Ultimate Fallback";
        Console.WriteLine(result5);

        string value8 = "Hello";
        string result6 = value8 ?? value2 ?? "This will not be used";
        Console.WriteLine(result6);

        Console.WriteLine("-----");

        // Null-Conditional Operators
        string str1 = null;
        int? length1 = str1?.Length;
        Console.WriteLine(length1);

        string str2 = "Hello";
        int? length2 = str2?.Length;
        Console.WriteLine(length2);

        string str3 = null;
        string result7 = str3?.ToUpper() ?? "String was null";
        Console.WriteLine(result7);

        string str4 = "C#";
        string result8 = str4?.ToLower() ?? "Default String";
        Console.WriteLine(result8);

        string str5 = null;
        string result9 = str5?.ToString() ?? "No String Found";
        Console.WriteLine(result9);

        string str6 = "Null-Conditional";
        string result10 = str6?.Substring(0, 4) ?? "Substring Failed";
        Console.WriteLine(result10);
    }
}
/*
Default Value
Default Value
Value A
Final Default Value
Default Value
Hello
-----

5
String was null
c#
No String Found
Null

*/

//52
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Program 1: Simple Lambda Expression
        Func<int, int> square = x => x * x;
        int result1 = square(5); // result1 = 25

        // Program 2: Lambda with List
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> squaredNumbers = numbers.ConvertAll(x => x * x); // squaredNumbers = {1, 4, 9, 16, 25}

        // Program 3: Delegate with Method
        Func<int, int> multiplyByTwo = MultiplyByTwo;
        int result3 = multiplyByTwo(4);  // result3 = 8

        // Program 4: Lambda with Condition
        Func<int, string> checkEvenOrOdd = x => (x % 2 == 0) ? "Even" : "Odd";
        string result4 = checkEvenOrOdd(10);  // result4 = "Even"

        // Program 5: Using Action Delegate
        Action<string> greet = name => Console.WriteLine($"Hello, {name}");
        greet("iConnect");  // Output: Hello, iConnect

        // Program 6: Lambda with LINQ
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        var nameLengths = names.Select(name => name.Length).ToList(); 
        
        // ----------------------------
        
        // Program 1: Simple Indexing
        int[] array = { 10, 20, 30, 40, 50 };
        int value1 = array[2]; // value1 = 30

        // Program 2: List Indexing
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        string fruit = fruits[1]; // fruit = "Banana"

        // Program 3: Indexing with Property Access
        var person = new { Name = "John", Age = 30 };
        string name = person.Name;  // name = "John"

        // Program 4: Accessing Elements in a Dictionary
        Dictionary<string, int> ageDict = new Dictionary<string, int> { { "Alice", 25 }, { "Bob", 30 } };
        int aliceAge = ageDict["Alice"]; // aliceAge = 25

        // Program 5: Indexing in Multi-Dimensional Array
        int[,] multiArray = { { 1, 2 }, { 3, 4 } };
        int value2 = multiArray[1, 0];  // value2 = 3

        // Program 6: Indexing with Member Access
        var car = new { Make = "Toyota", Model = "Camry" };
        string carMake = car.Make; //Toyota
    }

    static int MultiplyByTwo(int x)
    {
        return x * 2;
    }
}








