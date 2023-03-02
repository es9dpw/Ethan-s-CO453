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
        string impHeight;
        string impWeight;
        Int32 count;

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
                    OutputBMI();
                }
                
                else if (string.Equals(units, "")){
                    exit = true;
                    Console.WriteLine("Exiting Calculator...\n");
                }
                
                else{
                    Console.WriteLine("Invalid option.\n");
                }
            }
        }

        public void UnitType()
        {
            Console.Write("Enter which unit type you would like to use, 'metric' or 'imperial'. Or enter nothing to exit the calculator: ");
            units = Console.ReadLine();
        }

        public void InputHeight()
        {
            if (string.Equals(units, "metric")){
                Console.Write("Please enter your height in metres: ");
                heightInput = Convert.ToDouble(Console.ReadLine());
            }
            else if (string.Equals(units, "imperial")){
                Console.Write("Please enter your height in the following format: '(feet)ft (inches)in'. For example, '6ft 2in': ");
                impHeight = Console.ReadLine();
                
                String[] spearator1 = { "ft ", "ft " };
                count = 2;
                String[] feet = impHeight.Split(spearator1, count, StringSplitOptions.RemoveEmptyEntries);

                String[] spearator2 = { "in", "in" };
                count = 2;
                String[] inches = feet[1].Split(spearator2, count, StringSplitOptions.RemoveEmptyEntries);
                
                heightInput=((Convert.ToDouble(feet[0])) * 12) + (Convert.ToDouble(inches[0]));
            }
        }

        public void InputWeight()
        {
            if (string.Equals(units, "metric")){
                Console.Write("Please enter your weight in kilograms: ");
                weightInput = Convert.ToDouble(Console.ReadLine());
            }
            else if (string.Equals(units, "imperial")){
                Console.Write("Please enter your weight in the following format: '(stone)st (pounds)lb'. For example, '12st 8lb': ");
                impWeight = Console.ReadLine();
                
                String[] spearator1 = { "st ", "st " };
                count = 2;
                String[] stone = impWeight.Split(spearator1, count, StringSplitOptions.RemoveEmptyEntries);

                String[] spearator2 = { "lb", "lb" };
                count = 2;
                String[] pounds = stone[1].Split(spearator2, count, StringSplitOptions.RemoveEmptyEntries);
                
                weightInput=((Convert.ToDouble(stone[0])) * 14) + (Convert.ToDouble(pounds[0]));
            }
        }

        public void CalculateBMI()
        {
            if (string.Equals(units, "metric")){
                bmi = weightInput / Math.Pow(heightInput, 2);
            }
            else if (string.Equals(units, "imperial")){
                bmi = (weightInput * 703) / Math.Pow(heightInput, 2);
            }
        }

        public void OutputBMI()
        {
            Console.Write("Your BMI is " + bmi +". This means you are ");
            if (bmi<18.5){
                Console.WriteLine("underwieght, as your BMI is less than 18.5.\n");
            }
            else if ((bmi >= 18.5) && (bmi < 25)){
                Console.WriteLine("normal, as your BMI is between than 18.5 and 24.9.\n");
            }
            else if ((bmi >= 25) && (bmi < 30)){
                Console.WriteLine("overweight, as your BMI is between than 25.0 and 29.9.\n");
            }
            else if ((bmi >= 30) && (bmi < 35)){
                Console.WriteLine("in obese class I, as your BMI is between than 30.0 and 34.9.\n");
            }
            else if ((bmi >= 35) && (bmi < 40)){
                Console.WriteLine("in obese class II, as your BMI is between than 35.0 and 39.9.\n");
            }
            else if (bmi >= 40){
                Console.WriteLine("in obese class III, as your BMI is above 40.0.\n");
            }
        }
    }
}