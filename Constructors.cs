// // What is a Constructor?

// // A constructor is a special piece of code in a class that runs automatically when you create an object using the word new.

// public class Car
// {
//     public string color;
//     public string brand;

//     // --- THIS IS THE CONSTRUCTOR ---
//     // Rule 1: It must have the EXACT same name as the Class (Car).
//     // Rule 2: It has NO return type (not even void).
//     public Car(string incomingColor, string incomingBrand)
//     {
//         // We take the data the user gave us (incomingColor)
//         // and put it into our variable (color).
//         color = incomingColor;
//         brand = incomingBrand;
//     }

//     public void Drive()
//     {
//         Console.WriteLine($"The {color} {brand} is driving!");
//     }
// }

// public class Program
// {
//     static void Main(string[] args)
//     {
//         // When we create a new Car, we MUST give it the color and brand.
//         Car myCar = new Car("Red", "Toyota");
//         Car yourCar = new Car("Yellow", "Ferrari");

//         myCar.Drive();
//         yourCar.Drive();
//     }
// }