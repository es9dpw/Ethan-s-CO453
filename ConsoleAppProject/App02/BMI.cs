using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app takes the users height and weight inputs, calculates and then outputs their BMI
    /// </summary>
    /// <author>
    /// Ethan Smith
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
        //defines the variable types

        public void Run()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("               App02: BMI Calculator              ");
            Console.WriteLine("                  by Ethan Smith                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("     This is an app to calcualte someones BMI     ");
            Console.WriteLine("           using their height and weight          ");
            Console.WriteLine(" =================================================\n");
            //creates the heading for the app and displays it to the user

            while(exit == false){
            //creates a loop to keep the app running until the user manually exits it
                UnitType();
                //calls the UnitType method

                if (string.Equals(units, "metric") || string.Equals(units, "imperial")){
                //checks if the entred a valid unit type
                    InputHeight();
                    InputWeight();
                    CalculateBMI();
                    OutputBMI();
                }
                
                else if (string.Equals(units, "")){
                    exit = true;
                    Console.WriteLine("Exiting Calculator...\n");
                }
                //checks if the user enters nothing to exit the program and breaks the loop
                
                else{
                    Console.WriteLine("Invalid option.\n");
                }
                //if none of the unit type options are entered then an error is diplayed
            }
        }

        public void UnitType()
        {
            Console.Write("Enter which unit type you would like to use, 'metric' or 'imperial'. Or enter nothing to exit the calculator: ");
            units = Console.ReadLine();
        }
        //takes the users input on what unit type they want to use

        public void InputHeight()
        {
            if (string.Equals(units, "metric")){
                Console.Write("Please enter your height in metres: ");
                heightInput = Convert.ToDouble(Console.ReadLine());
            }
            //if the user wants to use the metric system, they enter their height in metres
            else if (string.Equals(units, "imperial")){
                Console.Write("Please enter your height in the following format: '(feet)ft (inches)in'. For example, '6ft 2in': ");
                impHeight = Console.ReadLine();
                //if the user wants to use the imperial system, they enter their height in feet and inches
                
                String[] spearator1 = { "ft ", "ft " };
                count = 2;
                String[] feet = impHeight.Split(spearator1, count, StringSplitOptions.RemoveEmptyEntries);
                //splits the string entred by the user into the number of feet and the number of inches with the 'in' shorthand to allow the feet to be used in calculations

                String[] spearator2 = { "in", "in" };
                count = 2;
                String[] inches = feet[1].Split(spearator2, count, StringSplitOptions.RemoveEmptyEntries);
                //splits the second string in the feet array into the number of inches and a blank string to allow the inches to be used in calculations
                
                heightInput=((Convert.ToDouble(feet[0])) * 12) + (Convert.ToDouble(inches[0]));
                //uses the values in the arrays to convert the feet and inches input to just inches for use in BMI calculations
            }
        }

        public void InputWeight()
        {
            if (string.Equals(units, "metric")){
                Console.Write("Please enter your weight in kilograms: ");
                weightInput = Convert.ToDouble(Console.ReadLine());
            }
            //if the user wants to use the metric system, they enter their weight in kilograms
            else if (string.Equals(units, "imperial")){
                Console.Write("Please enter your weight in the following format: '(stone)st (pounds)lb'. For example, '12st 8lb': ");
                impWeight = Console.ReadLine();
                //if the user wants to use the imperial system, they enter their weight in stone and pounds
                
                String[] spearator1 = { "st ", "st " };
                count = 2;
                String[] stone = impWeight.Split(spearator1, count, StringSplitOptions.RemoveEmptyEntries);
                //splits the string entred by the user into the number of stone and the number of pounds with the 'lb' shorthand to allow the stones to be used in calculations

                String[] spearator2 = { "lb", "lb" };
                count = 2;
                String[] pounds = stone[1].Split(spearator2, count, StringSplitOptions.RemoveEmptyEntries);
                //splits the second string in the stone array into the number of pounds and a blank string to allow the pounds to be used in calculations
                
                weightInput=((Convert.ToDouble(stone[0])) * 14) + (Convert.ToDouble(pounds[0]));
                //uses the values in the arrays to convert the stones and pounds input to just pounds for use in BMI calculations
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
        //calculates the BMI depending on which unit type the user selected

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
        //outputs the users BMI and then checks which BMI class they fall into and displays it to them
    }
}