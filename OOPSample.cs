using System;

public class Person
{
    // Private fields (encapsulated data)
    private string name;
    private int age;

    // Public methods to access and modify the encapsulated data
    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        if (!string.IsNullOrEmpty(newName))
        {
            name = newName;
        }
        else
        {
            Console.WriteLine("Name cannot be empty!");
        }
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative!");
        }
    }

    // Constructor to initialize the object
    public Person(string initialName, int initialAge)
    {
        // Use the property setters to ensure validation
        SetName(initialName);
        SetAge(initialAge);
    }

    // Other methods can be added for additional behavior
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Person class
        Person person1 = new Person("John Doe", 25);

        // Accessing encapsulated data through public methods
        Console.WriteLine($"Name: {person1.GetName()}, Age: {person1.GetAge()}");

        // Modifying encapsulated data through public methods
        person1.SetName("Jane Doe");
        person1.SetAge(30);

        // Displaying information using a public method
        person1.DisplayInfo();
    }
}