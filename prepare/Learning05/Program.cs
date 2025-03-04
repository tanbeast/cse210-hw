using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        var square1 = new Square("Red", 7);
        var rect = new Rectangle("Blue", 4, 5);
        var circ = new Circle("Black", 5);
        Console.WriteLine($"Shape Color: {square1.Color}, Area: {square1.GetArea()}");
        Console.WriteLine($"Shape Color: {rect.Color}, Area: {rect.GetArea()}");
        Console.WriteLine($"Shape Color: {circ.Color}, Area: {circ.GetArea()}");

    }
}