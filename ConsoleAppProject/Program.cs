using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public class Program
    {
        bool exit = false;
        string appChoice;
        public void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n =================================================");
            Console.WriteLine("   BNU CO453 Applications Programming 2022-2023!  ");
            Console.WriteLine("                  by Ethan Smith                  ");
            Console.WriteLine(" =================================================\n");

            while(exit == false){
                Console.Write("Enter the number of the app would you like to run: 1. Distance Converter, 2. BMI Calculator. Or enter nothing to exit the converter: ");
                appChoice = Console.ReadLine();
                
                if (string.Equals(appChoice, "1")){
                    DistanceConverter converter = new DistanceConverter();
                    converter.Run();
                }
                
                else if (string.Equals(appChoice, "2")){
                    BMI calculator = new BMI();
                    calculator.Run();
                }
                
                else if (string.Equals(appChoice, "")){
                    exit = true;
                    Console.WriteLine("Exiting Program...\n");
                }
                
                else{
                    Console.WriteLine("Invalid option.\n");
                }
            }
        }
    }
}
