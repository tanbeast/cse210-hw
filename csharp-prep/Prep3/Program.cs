using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        do
        {
            Console.WriteLine("Hello Prep3 World!");
            Random randomgenerator = new Random();
            int magicNumber = randomgenerator.Next(1, 10);
            int guessNumber = 0;
            int guesses = 1;


            Console.WriteLine("guess a number between 1 and 10.");
            do
            {
                Console.Write("what is your guess:");
                guessNumber = int.Parse(Console.ReadLine());
                Console.Write(guessNumber);

            } while (guessNumber != magicNumber);
        } while (play == "yes");
    }
}