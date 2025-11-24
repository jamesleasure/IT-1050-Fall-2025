using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating the first Car object.
        // This demonstrates how to instantiate an object from a class.
        Car myCar = new Car();

        // Assigning values to the object's fields.
        // This demonstrates how objects can hold data using fields.
        myCar.make = "Chevy";
        myCar.model = "Cruise";
        myCar.color = "white";
        myCar.currentSpeed = 0;
        myCar.isOn = false;

        // Calling a method that returns a value.
        // This demonstrates how methods can run logic and update the object's state.
        Console.WriteLine($"The car is on: {myCar.TurnOn(35)}");

        // Using a loop to repeatedly call a method on the object.
        // This demonstrates how methods can be used inside loops to change an object's state over time.
        for (int i = 0; i < 5; i++)
        {
            myCar.SpeedUp();   // Default speed increase by 1
        }

        // Calling an overloaded version of SpeedUp.
        // This demonstrates method overloading — same method name, different parameters.
        myCar.SpeedUp(100);

        // Display the updated state of the object.
        // This demonstrates how an object can report its current data.
        myCar.Display();

        // Calling a static method.
        // This demonstrates that static methods belong to the class itself, not to individual objects.
        Car.Honk();

        // Creating a second Car object.
        // This demonstrates that each object created from the same class is independent.
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
    // Public fields that store the state of each Car object.
    // This demonstrates how each object keeps its own independent set of data.
    public string make;
    public string model;
    public string color;
    public int currentSpeed;
    public bool isOn;

    // Method that prints all the car's information.
    // This demonstrates how methods can access and display an object's field values.
    public void Display()
    {
        Console.WriteLine($"Make: {make}, Model: {model}, Color: {color}, Current Speed: {currentSpeed}, Is On: {isOn}");
    }

    // Method that turns the car on or off.
    // This demonstrates how methods can use parameters, write logic, modify fields, and return values.
    public bool TurnOn(int temp)
    {
        // This demonstrates how conditional logic can be used inside methods.
        if (temp < 40)
        {
            Console.WriteLine("Engine block heater started");
        }

        // Toggle the on/off state.
        // This demonstrates how methods can change the internal state of an object.
        isOn = !isOn;

        Console.WriteLine($"The car is now {(isOn ? "On" : "Off")}");
        return this.isOn;
    }

    // Method that increases speed by 1.
    // This demonstrates a method with no parameters and a return type.
    public int SpeedUp()
    {
        currentSpeed++;
        return currentSpeed;
    }

    // Overloaded method that increases speed by a specified amount.
    // This demonstrates method overloading: same name, different parameter list.
    public int SpeedUp(int mph)
    {
        currentSpeed += mph;
        return currentSpeed;
    }

    // Another overloaded version with a speed limit and message.
    // This demonstrates how overloading allows different logic based on parameters.
    public int SpeedUp(int speedLimit, string message)
    {
        if (currentSpeed < speedLimit)
        {
            currentSpeed++;
        }
        else
        {
            // This demonstrates how a method can provide feedback when a condition is not met.
            Console.WriteLine(message);
        }
        return currentSpeed;
    }

    // Static method.
    // This demonstrates how a method can belong to the class itself instead of an object.
    public static void Honk()
    {
        Console.WriteLine("Beep Beep!");
    }
}
