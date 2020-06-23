
using System;
using System.Collections.Generic;

namespace _4_5Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list to hold the scores.
            List<int> scores = new List<int>();
            scores.Add(1200);
            scores.Add(4400);
            scores.Add(3700);
            scores.Add(8900);
            scores.Add(7200);


            //2.Sort the list low-high
            scores.Sort();

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            //3.Sort the list high-low
            scores.Reverse();

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            //4.Add a new score
            scores.Add(2400);

            //5. Remove Score
            scores.Remove(4400);

        }
    }
}