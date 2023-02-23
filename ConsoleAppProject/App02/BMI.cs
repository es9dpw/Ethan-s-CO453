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
        bool exit = false;
        string units;
        double weightInput;
        double heightInput;
        double bmi;
        public void Run()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("               App02: BMI Calculator              ");
            Console.WriteLine("                  by Ethan Smith                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("     This is an app to calcualte someones BMI     ");
            Console.WriteLine("           using their height and weight          ");
            Console.WriteLine(" =================================================\n");

            while(exit == false){
                UnitType();

                if (string.Equals(units, "metric") || string.Equals(units, "imperial")){
                    InputHeight();
                    InputWeight();
                    CalculateBMI();
                }
                
                else if (string.Equals(units, "")){
                    exit = true;
                    Console.WriteLine("Exiting Converter...\n");
                }
                
                else{
                    Console.WriteLine("Invalid option.\n");
                }
            }
        }

        public void UnitType()
        {
            Console.Write("Enter which unit type you would like to use, 'metric' or 'imperial'. Or enter nothing to exit the converter: ");
            units = Console.ReadLine();
        }

        public void InputHeight()
        {
            Console.Write("Please enter your height: ");
            heightInput = Convert.ToDouble(Console.ReadLine());
        }

        public void InputWeight()
        {
            Console.Write("Please enter your weight: ");
            weightInput = Convert.ToDouble(Console.ReadLine());
        }

        public void CalculateBMI()
        {
            
        }
    }
}