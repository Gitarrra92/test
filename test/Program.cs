using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imie ");
            string name = Console.ReadLine();
            Console.WriteLine("hello, {0} lets play a game", name );

            int correctNumber = 7;
            int guess = 0;
            Console.WriteLine("Guess a number between 0-10");

            while (guess != correctNumber) {
                string inputUser = Console.ReadLine();
                guess = Int32.Parse(inputUser);

                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number");
                    Console.ResetColor();
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct");
                    Console.ResetColor();
                }
            }
        }
    }
}
