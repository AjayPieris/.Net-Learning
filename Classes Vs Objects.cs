
public class Car
{
    // VARIABLES (What the car IS)
    public string color;
    public string brand;
    public int maxSpeed;

    // METHODS (What the car DOES)
    public void Drive()
    {
        Console.WriteLine($"The {color} {brand} is driving fast!");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Create Car #1 (My Car)
        Car myCar = new Car(); 
        myCar.brand = "Toyota";
        myCar.color = "Red";
        myCar.maxSpeed = 120;

        // Create Car #2 (Your Car)
        Car yourCar = new Car();
        yourCar.brand = "Ferrari";
        yourCar.color = "Yellow";
        yourCar.maxSpeed = 200;

        // Make them drive
        myCar.Drive();
        yourCar.Drive();
    }
}
