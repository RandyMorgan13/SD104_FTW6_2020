using System;
using System.Collections.Generic;

namespace Lab5_2
{
    class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thors_day,
            Freyas_day,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {

            //2.Create a task list
            List<string> taskList = new List<string>();

            //3.for each value in the Enum, let the user create a task
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);

            }
            //4.print all of the tasks.
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}