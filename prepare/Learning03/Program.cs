using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction one = new Fraction();
        one.Test();
        one.top = 6;
        Console.WriteLine($"{one.top}");
        
        Fraction two = new Fraction();
        two.Test(6);
        two.top = 6;
        Console.WriteLine($"{two.top}");
        
        Fraction three = new Fraction();
        three.Test(6,7);
        three.top = 6;
        Console.WriteLine($"{three.top}");
    }
}