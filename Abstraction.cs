// using System;

// // Abstract class
// abstract class Animal
// {
//     public string Name { get; set; }

//     public Animal(string name)
//     {
//         Name = name;
//     }

//     // Abstract method (no body)
//     public abstract void Sound();

//     // Normal method (has body)
//     public void Eat()
//     {
//         Console.WriteLine(Name + " is eating.");
//     }
// }

// // Derived class
// class Dog : Animal
// {
//     public Dog(string name) : base(name) { }

//     // Must override abstract method
//     public override void Sound()
//     {
//         Console.WriteLine(Name + " barks: Woof Woof!");
//     }
// }

// // Derived class
// class Cat : Animal
// {
//     public Cat(string name) : base(name) { }

//     public override void Sound()
//     {
//         Console.WriteLine(Name + " meows: Meow!");
//     }
// }

// // Main program
// class Program
// {
//     static void Main()
//     {
//         Animal myDog = new Dog("Buddy");
//         myDog.Sound();   // Buddy barks: Woof Woof!
//         myDog.Eat();     // Buddy is eating.

//         Animal myCat = new Cat("Whiskers");
//         myCat.Sound();   // Whiskers meows: Meow!
//         myCat.Eat();     // Whiskers is eating.
//     }
// }
