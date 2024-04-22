//  1 ) Data Types and Variables
// Data Types: In C#, every variable has a data type, which defines the type of data it can hold. Common data types include:

// int: Integer numbers (e.g., 1, 2, -5)
// float, double: Floating-point numbers (e.g., 3.14, -0.5)
// char: Single characters (e.g., 'a', 'B')
// string: Textual data (e.g., "Hello, World!")

int age = 20 ;
float height = 2.22;
string name= "sufiyan";

// 2 ) Control Structures:

// If-Else Statements:
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}

// Loops:
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Number: " + i);
}

// While Loop:

int i = 0;
while (i < 5)
{
    Console.WriteLine("Number: " + i);
    i++;
}

// Methods: Functions in C# are called methods. They encapsulate a set of instructions
int Add(int a, int b)
{
    return a + b;
}

// Calling Methods
int result = Add(5, 3);