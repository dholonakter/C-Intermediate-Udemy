// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("ABC123");
    }
}

public class Vehicle
{
    private readonly string _registrationNumber;
    //public Vehicle()
    //{
    //    Console.WriteLine("Vehicle is created");
    //}
    public Vehicle(string registrationNumber)
    {
        this._registrationNumber = registrationNumber;
        Console.WriteLine("Vehicle is created {0} ", registrationNumber);
    }
    
}
public class Car : Vehicle
{
    public Car(string registrationNumber) : base(registrationNumber)
    {
        Console.WriteLine("Car is created {0}", registrationNumber);
    }
}