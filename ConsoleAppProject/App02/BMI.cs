using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        double weightInput;
        double heightInput;
        double bmi;
        string units;
        public void Run()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("               App02: BMI Calculator              ");
            Console.WriteLine("                  by Ethan Smith                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("     This is an app to calcualte someones BMI     ");
            Console.WriteLine("           using their height and weight          ");
            Console.WriteLine(" =================================================\n");

            
        }

        public void UnitType()
        {
            Console.Write("Enter which unit type you would like to use, 'metric' or 'imperial'. Or enter nothing to exit the converter: ");
            units = Console.ReadLine();
        }
    }
}
