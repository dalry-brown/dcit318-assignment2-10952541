using System;

public class Program
{
    public static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();
        
        myAnimal.MakeSound(); // Outputs: Some generic sound
        myDog.MakeSound();    // Outputs: Bark
        myCat.MakeSound();    // Outputs: Meow
    }
}
