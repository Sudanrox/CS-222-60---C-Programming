// Exercise 6.2 – Inheritance Hierarchy Example
using System;

namespace Exercise02
{
    // Base class Shape
    abstract class Shape
    {
        public double Height { get; protected set; }
        public double Width { get; protected set; }

        // Abstract property Area must be implemented in derived classes
        public abstract double Area { get; }
    }

    // Rectangle inherits from Shape
    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area => Height * Width;
    }

    // Square inherits from Shape
    class Square : Shape
    {
        public Square(double size)
        {
            Height = size;
            Width = size;
        }

        public override double Area => Height * Width;
    }

    // Circle inherits from Shape
    class Circle : Shape
    {
        public Circle(double radius)
        {
            Height = radius * 2; // Diameter
            Width = radius * 2;  // Diameter
        }

        public override double Area => Math.PI * Math.Pow(Width / 2, 2); // Area = πr²
    }

    // Main program to demonstrate usage
    class Program
    {
        static void Main(string[] args)
        {
            // Create and display a Rectangle
            var r = new Rectangle(3, 4.5);
            Console.WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}");

            // Create and display a Square
            var s = new Square(5);
            Console.WriteLine($"Square H: {s.Height}, W: {s.Width}, Area: {s.Area}");

            // Create and display a Circle
            var c = new Circle(2.5);
            Console.WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area: {c.Area}");
        }
    }
}