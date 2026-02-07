// // // The Parent
// // class Vehicle
// // {
// //     public int speed = 0;

// //     public void Go()
// //     {
// //         Console.WriteLine("This vehicle is moving!");
// //     }
// // }

// // // The Child: Car
// // // "class Car : Vehicle" means Car IS A Vehicle.
// // class Car : Vehicle
// // {
// //     public int wheels = 4; // Car adds its own special variable
// // }

// // // The Child: Bicycle
// // class Bicycle : Vehicle
// // {
// //     public int wheels = 2; // Bicycle adds its own special variable
// // }
// // class Program
// // {
// // static void Main(string[] args)
// // {
// //     Car myCar = new Car();
    
// //     // 1. Using the Parent's method
// //     myCar.Go(); 
// //     // Output: "This vehicle is moving!" (It works!)

// //     // 2. Using the Child's variable
// //     Console.WriteLine(myCar.wheels); 
// //     // Output: 4

// //     // -----------------------------

// //     Bicycle myBike = new Bicycle();
    
// //     // The Bike ALSO has Go(), even though we never wrote it inside Bicycle!
// //     myBike.Go();
// //     // Output: "This vehicle is moving!"
// //     Console.WriteLine(myBike.wheels);
// //     // Output: 2    
// //     }
// // }

// // private = only inside the class
// // protected = inside the class AND inside any child classes

// // THE PARENT
// class Father
// {
//     // 1. PRIVATE: Only Father knows this.
//     private string _secretDiary = "I love disco music";

//     // 2. PROTECTED: Father and Kids know this.
//     protected string _familyRecipe = "Secret BBQ Sauce";

//     // 3. PUBLIC: Everyone knows this.
//     public string Name = "John";
// }

// // THE CHILD
// // Remember: " : Father" means Child inherits from Father
// class Son : Father
// {
//     public void RevealSecrets()
//     {
//         // TRYING TO READ PRIVATE (The Diary)
//         // Console.WriteLine(_secretDiary); 
//         // ERROR! The computer will scream: 
//         // "Father._secretDiary is inaccessible due to its protection level."
        
//         // TRYING TO READ PROTECTED (The Family Recipe)
//         Console.WriteLine(_familyRecipe); 
//         // SUCCESS! The Son is allowed to know the Family Recipe.
        
//         // TRYING TO READ PUBLIC (The Name)
//         Console.WriteLine(Name);
//         // SUCCESS! Everyone knows the name.
//     }
// }
// class Program
// {
// static void Main(string[] args)
// {
//     Son mySon = new Son();
//     Father myNeighbor = new Father();

//     // 1. Can Neighbor see Public?
//     Console.WriteLine(mySon.Name); // YES.

//     // 2. Can Neighbor see Protected?
//     // Console.WriteLine(mySon._familyRecipe); 
//     // ERROR! The neighbor is NOT family. They cannot see protected items.

//     // 3. Can Neighbor see Private?
//     // Console.WriteLine(mySon._secretDiary);
//     // ERROR! Definitely not.
// }
// }