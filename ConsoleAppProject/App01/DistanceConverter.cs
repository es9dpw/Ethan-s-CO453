using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public void Run()
        {
            Console.Write("Please enter the number of miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            const int mTOf = 5280;
            double feet = miles * mTOf;
            Console.WriteLine("There are " + feet + " feet in " + miles + " miles.");
        }
    }
}