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
        const int mTOf = 5280;
        int choice;
        double miles;
        double feet;
        bool exit = false;

        public void Run()
        {
            while(exit == false){
                Menu();
            
                if (choice == 1){
                    InputMiles();
                    ConvertMilesToFeet();
                    OutputFeet();
                    Console.WriteLine("");
                }
            
                else if (choice == 2){
                    InputFeet();
                    ConvertFeetToMiles();
                    OutputMiles();
                    Console.WriteLine("");
                }

                else if (choice == 3){
                    exit = true;
                    Console.WriteLine("Exiting Converter\n");
                }

                else{
                    Console.Write("\nInvalid option. ");
                }
            }
        }

        public void Menu()
        {
            Console.Write("Enter 1 to convert miles to feet, enter 2 to convert feet to miles and enter 3 to exit the converter: ");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        
        public void InputMiles()
        {
            Console.Write("Please enter the number of miles: ");
            miles = Convert.ToDouble(Console.ReadLine());
        }
        
        public void InputFeet()
        {
            Console.Write("Please enter the number of feet: ");
            feet = Convert.ToDouble(Console.ReadLine());
        }
        
        public void ConvertMilesToFeet()
        {
            feet = miles * mTOf;
        }

        public void ConvertFeetToMiles()
        {
            miles = feet / mTOf;
        }
        
        public void OutputMiles()
        {
            Console.WriteLine("There are " + miles + " miles in " + feet + " feet.");
        }
        
        public void OutputFeet()
        {
            Console.WriteLine("There are " + feet + " feet in " + miles + " miles.");
        }
    }
}