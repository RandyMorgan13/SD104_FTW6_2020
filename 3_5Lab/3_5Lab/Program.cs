using System;

namespace Lesson3SpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "Expletive";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("You can't say that!");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("Yeah, you can say that.");
            }
        }
    }
}