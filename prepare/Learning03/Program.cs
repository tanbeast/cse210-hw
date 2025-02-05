using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction one = new Fraction();
        one.Test();
        
        Fraction two = new Fraction();
        two.Test(6);
        
        Fraction three = new Fraction();
        three.Test(6,7);
    }
}