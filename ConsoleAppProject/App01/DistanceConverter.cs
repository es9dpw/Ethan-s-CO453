using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app converts different units of measurment
    /// </summary>
    /// <author>
    /// Ethan
    /// </author>
    public class DistanceConverter
    {
        const int mTOf = 5280;
        bool exit = false;
        string choice;
        double miles;
        double feet;

        public void Run()
        {
            while(exit == false){
                Menu();
            
                if (string.Equals(choice, "1")){
                    InputMiles();
                    ConvertMilesToFeet();
                    OutputFeet();
                    Console.WriteLine("");
                }
            
                else if (string.Equals(choice, "2")){
                    InputFeet();
                    ConvertFeetToMiles();
                    OutputMiles();
                    Console.WriteLine("");
                }

                else if (string.Equals(choice, "")){
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
            Console.Write("Enter 1 to convert miles to feet, enter 2 to convert feet to miles or enter nothing to exit the converter: ");
            choice = Console.ReadLine();
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