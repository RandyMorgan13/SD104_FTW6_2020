using System;
using System.Transactions;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Number 1

            int number1; //First Input
            int number2; //Second Input

            Console.WriteLine("Enter a value for the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The Answer Is?");
            Console.WriteLine(result);

            result = number1 - number2;
            Console.WriteLine("The Answer Is?");
            Console.WriteLine(result);


            result = number1 * number2;
            Console.WriteLine("The Answer Is?");
            Console.WriteLine(result);

            double results2 = (double)number1 / (double)number2;
            double results3 = number1 % number2;
            Console.WriteLine("The Answer Is?");
            Console.WriteLine(results2);

            //Number2
            Console.WriteLine("Enter Name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            //Number 3

            int number3; //First Input
            int number4; //Second Input
            int number5; //Third Input

            Console.WriteLine("Number 1");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplied By");
            number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplied By Again...");
            number5 = Convert.ToInt32(Console.ReadLine());

            result = number3 * number4 * number5;
            Console.WriteLine("Answer?");
            Console.WriteLine(result);

            //Number 4

            Console.WriteLine("Age?");
            var Age = Console.ReadLine();
            Console.WriteLine($"You look younger than {Age}");









        }
    }
}