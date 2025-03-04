using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        var square1 = new Square("Red", 5);
        Console.WriteLine($"Shape Color: {square1.Color}, Area: {square1.GetArea()}");

    }
}