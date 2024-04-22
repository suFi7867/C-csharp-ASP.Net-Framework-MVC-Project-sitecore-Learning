using System;

class Person
{
    // Fields
    public string Name;
    public int Age;

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void SayHello()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Use Case 1: Creating Person objects
        Person person1 = new Person("John", 30);
        Person person2 = new Person("Alice", 25);

        // Use Case 2: Accessing properties and methods
        Console.WriteLine("Person 1:");
        Console.WriteLine("Name: " + person1.Name);
        Console.WriteLine("Age: " + person1.Age);
        person1.SayHello();

        Console.WriteLine("\nPerson 2:");
        Console.WriteLine("Name: " + person2.Name);
        Console.WriteLine("Age: " + person2.Age);
        person2.SayHello();
    }
}
