using System;

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }

    public void Speak(int volume)
    {
        Console.WriteLine($"Dog barks at volume {volume}");
    }

    public void Speak(string message)
    {
        Console.WriteLine($"Dog says: {message}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Speak();

        Dog dog = new Dog();
        dog.Speak(); // method overriding

        dog.Speak(5); // method overloading
        dog.Speak("Hello"); // method overloading
    }
}