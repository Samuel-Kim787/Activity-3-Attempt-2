using System;
namespace ShapeCreator
{
    public abstract class Shape
    {
        public string color;
        public double sideLength;


        public Shape(string color, double sideLength) // constructor, constructing the shape
        {
            this.color = color;
            this.sideLength = sideLength;
            Console.WriteLine("Shape Created!");
        }



        ~Shape() // destructor, destroy the shape and send a message
        {
            Console.WriteLine("Shape Destroyed!");
        }

        public abstract double getArea();
        public void displayInfo()
        {
            Console.WriteLine($"Color: {color}, Area: {getArea()}");
        }
    }


    public class Square : Shape
    {
        
        public Square(string color, double sideLength) : base(color, sideLength)
        {
        }
        
        public override double getArea()
        {
            return sideLength * sideLength;
        }
    }

    public class Circle : Shape
    {
        public Circle(string color, double radius) : base(color, radius)
        {
        }

        public override double getArea()
        {
            return Math.PI * sideLength * sideLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape iskwer = new Square("Yellow", 10);
            iskwer.displayInfo();

            Shape bilog = new Circle("Green", 5);
            bilog.displayInfo();
        }
    }
}