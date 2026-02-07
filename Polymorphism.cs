// using System;

// class Animal
// {
//     // Runtime Polymorphism needs 'virtual'
//     public virtual void Sound()
//     {
//         Console.WriteLine("Animal makes a sound");
//     }
// }

// class Dog : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Dog barks");
//     }
// }

// class Cat : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Cat meows");
//     }
// }

// class MathOperations
// {
//     // Compile-time Polymorphism (Method Overloading)
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("=== Runtime Polymorphism ===");

//         Animal a;

//         a = new Dog();
//         a.Sound();   // Dog barks

//         a = new Cat();
//         a.Sound();   // Cat meows


//         Console.WriteLine("\n=== Compile-time Polymorphism ===");

//         MathOperations m = new MathOperations();

//         Console.WriteLine("Add(2,3) = " + m.Add(2, 3));
//         Console.WriteLine("Add(2,3,4) = " + m.Add(2, 3, 4));
//     }
// }
