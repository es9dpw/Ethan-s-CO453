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
            int miles = Convert.ToInt16(Console.ReadLine());
            int feet = miles * 5280;
            Console.WriteLine("There are " + feet + " feet in " + miles + " miles.");
        } 
    }
}
