﻿namespace Gjett_Tallet_Oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                PlayGame();
                var answer = Console.ReadLine();
                if (answer != "Y") repeat = false;
            }


        }


        private static void PlayGame()
        {
            var rand = new Random();
            var randomNumber = rand.Next(1, 101);
            Console.WriteLine("Guess a number between 1 and 100!");
            var userGuess = Convert.ToInt32(Console.ReadLine());

            while (userGuess != randomNumber)
            {
                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Høyere!");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Lavere!");
                }
                userGuess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You won");




        }
    }
}