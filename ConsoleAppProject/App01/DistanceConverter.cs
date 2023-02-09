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
        int choice = 0;
        double miles = 0;
        double feet = 0;

        public void Run()
        {
            Menu();
            if (choice == 1){
                MilesToFeet();
            }
            else if (choice == 2){
                FeetToMiles();
            }
            else{
                Menu();
            }
        }

        public void Menu()
        {
            Console.Write("Enter 1 to convert miles to feet, enter 2 to convert feet to miles");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        public void MilesToFeet()
        {
            Console.Write("Please enter the number of miles: ");
            miles = Convert.ToDouble(Console.ReadLine());
            feet = miles * mTOf;
            Console.WriteLine("There are " + feet + " feet in " + miles + " miles.");
        }
        public void FeetToMiles()
        {
            Console.Write("Please enter the number of feet: ");
            feet = Convert.ToDouble(Console.ReadLine());
            miles = feet / mTOf;
            Console.WriteLine("There are " + miles + " feet in " + miles + " feet.");
        }
    }
}