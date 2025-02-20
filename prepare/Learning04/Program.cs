using System;

class Program{
    static void Main(string[] args){
        Assignment one = new Assignment("David Laed", "Multiplication");
        Console.WriteLine(one.GetSummary());

        Math two = new Math("Kristy Wood", "Fractions", "7.5", "3-21");
        Console.WriteLine(two.GetSummary());
        Console.WriteLine(two.GetHomeworkList());

        Writing three = new Writing("Mary Mack", "History", "The Causes of World War");
        Console.WriteLine(three.GetSummary());
        Console.WriteLine(three.GetWritingInformation());
    }
}