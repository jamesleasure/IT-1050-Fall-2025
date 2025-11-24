using System;

class Program
{

    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.make = "Chevy";
        myCar.model = "Cruise";
        myCar.color = "white";
        myCar.currentSpeed = 0;
        myCar.isOn = false;
        Console.WriteLine($"The car is on: {myCar.TurnOn(35)}");
        myCar.Display();

        Car car2 = new Car();
        car2.make = "Ford";
        car2.model = "Focus";
        car2.color = "blue";
        car2.currentSpeed = 10;
        car2.isOn = true;
        car2.Display();

    }
}

class Car
{
    public string make;
    public string model;
    public string color;
    public int currentSpeed;
    public bool isOn;

    public void Display()
    {
        Console.WriteLine($"Make: {make}, Model: {model}, Color: {color}, Current Speed: {currentSpeed}, Is On: {isOn}");
    }

    public bool TurnOn(int temp)
    {
        if (temp < 40)
        {
            Console.WriteLine("Engine block heater started");
        }
        isOn = !isOn;
        Console.WriteLine($"The car is now {(isOn ? "On" : "Off")}");
        return this.isOn;
    }
}
