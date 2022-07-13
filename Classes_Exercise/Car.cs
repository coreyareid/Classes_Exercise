using System;
namespace Classes_Exercise;

// Exercise 1
public class Car
{
    // Peramerterized Constructor
    public Car(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }

    //properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    // Methods
     public void TheCar()
    {

        Console.WriteLine("\n\n Vehicle Information");
        Console.WriteLine($"Make of the car: {Make}");
        Console.WriteLine($"Model of the car: {Model}");
        Console.WriteLine($"Manufacture date: {Year}");
        Console.WriteLine($"Car color: {Color}");
    }



}

