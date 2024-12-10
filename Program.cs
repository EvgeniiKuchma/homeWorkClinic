using System;

namespace homeWorkClinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queueSize;
            int timePerPatient = 10;
            int minutes = 60;
            int hours;
            int minutesRisedue;

            Console.Write($"Pleace enter queue size: ");
            queueSize = Convert.ToInt32(Console.ReadLine());

            hours = queueSize * timePerPatient / minutes;
            minutesRisedue = queueSize * timePerPatient % minutes;

            Console.WriteLine($"You must wait in queue {hours} " +
                $"houres and {minutesRisedue} minutes.");
        }
    }
}
