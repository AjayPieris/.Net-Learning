// The Parent
class Vehicle
{
    public int speed = 0;

    public void Go()
    {
        Console.WriteLine("This vehicle is moving!");
    }
}

// The Child: Car
// "class Car : Vehicle" means Car IS A Vehicle.
class Car : Vehicle
{
    public int wheels = 4; // Car adds its own special variable
}

// The Child: Bicycle
class Bicycle : Vehicle
{
    public int wheels = 2; // Bicycle adds its own special variable
}
class Program
{
static void Main(string[] args)
{
    Car myCar = new Car();
    
    // 1. Using the Parent's method
    myCar.Go(); 
    // Output: "This vehicle is moving!" (It works!)

    // 2. Using the Child's variable
    Console.WriteLine(myCar.wheels); 
    // Output: 4

    // -----------------------------

    Bicycle myBike = new Bicycle();
    
    // The Bike ALSO has Go(), even though we never wrote it inside Bicycle!
    myBike.Go();
    // Output: "This vehicle is moving!"
    Console.WriteLine(myBike.wheels);
    // Output: 2    
    }
}