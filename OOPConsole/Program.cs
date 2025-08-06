using System;
using OOPConsole;

namespace OOPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Program2 name1 = new Program2();
            // Program2 name2 = new Program2();
            // name1.Hello("Santiago");
            // name2.Hello("Taguro");

            Vehicle kotse1 = new Vehicle();
            Car kotse2 = new Car();
            Car kotse3 = new Car();
            kotse1.StartEngine();
            kotse2.StartEngine();
            kotse2.UmaandarSa();
            kotse3.InputData("Red", 10000, 4);
            kotse3.intro();
        }
    }
}
public class Vehicle
{
    protected string color;
    protected double price;
    public void StartEngine()
    {
        Console.WriteLine("Broom broom");
    }
}
public class Car : Vehicle
{
    private int wheels;
    public void UmaandarSa()
    {
        Console.WriteLine("Umaandar sa lupa");
    }
    public void InputData(string color, double price, int wheels)
    {
        this.color = color;
        this.price = price;
        this.wheels = wheels;
    }
    public void intro()
    {
        Console.WriteLine($"This car is {this.color}, costs {this.price} and has {this.wheels} wheels.");
    }

    public void Introduce()
    {
        Console.WriteLine($"This car is (color), costs (price) and has (wheels) wheels.");
    }

    public void Passenger(string name)
    {
        Console.WriteLine($"Welcome {name}");
    }

    public void Passenger(int number)
    {
        if (number < 5)
        {
            Console.WriteLine("kasya kayong : (num)");
            return;
        }
        else
        {
            Console.WriteLine("Sobrang dami niyo na!");
        }
    }

    public override void travel()
    {
        Console.WriteLine("Travel by Land!");
    }
}




