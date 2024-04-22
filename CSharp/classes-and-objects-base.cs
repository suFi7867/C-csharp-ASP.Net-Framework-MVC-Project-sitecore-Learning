// Classes and Objects:
// Classes: Classes are blueprints for creating objects. They contain data members (fields) and methods:


class Person
{
    public string Name;
    public int Age;
   // public, meaning they can be accessed from outside the class.

// say hello is a method
// Return Type: This method doesn't return any value (void).
    public void SayHello()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
    }
}



// Objects: Objects are instances of classes. They represent real-world entities:

Person person1 = new Person();
person1.Name = "suFi";
person1.Age = 22;
person1.SayHello(); 
// print > Hello, my name is suFi and I am 22 years old.

Person person2 = new Person();
person2.Name = "Sohel";
person2.Age = 90;
person2.SayHello(); 
// print > Hello, my name is Sohel and I am 90 years old.



// Encapsulation:

// Public Access: Both variables (Name and Age) and the method (SayHello) are declared as public, allowing them to be accessed from outside the class.

// Data Hiding: Although the variables are public, it's generally recommended to encapsulate data by using private variables and providing public properties or methods to access and modify them. This helps maintain data integrity and provides better control over access to the class's internal state.