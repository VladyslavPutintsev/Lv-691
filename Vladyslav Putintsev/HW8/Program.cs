using System;
using System.Collections.Generic;
using System.Linq;

namespace Homeworks
{

    internal class Program
    {
               
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Shape shape = new Circle("First Cirlce", 10);
            shapes.Add(shape);
            shape = new Square("First Square", 5);
            shapes.Add(shape);
            shape = new Circle("Second Cirlce", 2.3);
            shapes.Add(shape);
            shape = new Square("Second Square", 3.8);
            shapes.Add(shape);
            shape = new Circle("Third Cirlce", 6);
            shapes.Add(shape);
            shape = new Square("Third Square", 9);
            shapes.Add(shape);
            shape = new Circle("Forth Cirlce", 6.6);
            shapes.Add(shape);
            shape = new Square("Forth Square", 12);
            shapes.Add(shape);
            shape = new Circle("Fiveth Cirlce", 7);
            shapes.Add(shape);
            shape = new Square("Fiveth Square", 5.53);
            shapes.Add(shape);


            foreach (var s in shapes)
            {
                Console.WriteLine($"Name:{s.Name} Area: {s.Area()} Perimeter: {s.Perimeter()}");
            }

            Console.WriteLine("*******Shapes with Max Perimeter:*********");
            double maxPerimeter=shapes.Max(p => p.Perimeter());

            //There is a possibility to get more than 1 shape with the same Max Perimeter. So we have to show all possible shapes.
            foreach( var sh in shapes.FindAll(p => p.Perimeter() == maxPerimeter))
            {
                Console.WriteLine($"Shape with a maximum Perimeter is {sh.Name}. Perimeter: {sh.Perimeter()}.");
            }

            Console.WriteLine("*******Sorting by Area.*********");

            shapes.Sort();
            foreach (var sh in shapes)
            {
                Console.WriteLine($"Shape {sh.Name}. Area: {sh.Area()}.");
            }
            Console.ReadKey();

            

            
        }

       
    }
}
