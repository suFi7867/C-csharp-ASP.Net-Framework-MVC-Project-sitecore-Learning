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
    public virtual void SayHello()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
    }
}

class Employee : Person
{
    // Fields
    private string department;

    // Constructor
    public Employee(string name, int age, string department) : base(name, age)
    {
        this.department = department;
    }

    // Method overriding
    public override void SayHello()
    {
        Console.WriteLine("Hello, my name is " + Name + ", I am " + Age + " years old, and I work in the " + department + " department.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create Person object
        Person person = new Person("John", 30);
        person.SayHello(); // Output: Hello, my name is John and I am 30 years old.

        // Create Employee object
        Employee employee = new Employee("Alice", 25, "HR");
        employee.SayHello(); // Output: Hello, my name is Alice, I am 25 years old, and I work in the HR department.
    }
}
