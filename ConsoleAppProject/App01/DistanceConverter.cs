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
        const double miTOf = 5280;
        const double miTOm = 1609.34;
        const double mTOf = (5280 / 1609.34);
        bool exit = false;
        string convertFrom;
        string convertTo;
        double inputValue;
        double outputValue;

        public void Run()
        {
            while(exit == false){
                ConvertFrom();
            
                if (string.Equals(convertFrom, "miles")){
                    ConvertTo();
                    if (string.Equals(convertTo, "metres")){
                        Input();
                        ConvertMilesToMetres();
                        Output();
                    }
                    else if (string.Equals(convertTo, "feet")){
                        Input();
                        ConvertMilesToFeet();
                        Output();
                    }
                    else{
                        Console.WriteLine("Invalid option.\n");
                    }
                }
            
                else if (string.Equals(convertFrom, "metres")){
                    ConvertTo();
                    if (string.Equals(convertTo, "miles")){
                        Input();
                        ConvertMetresToMiles();
                        Output();
                    }
                    else if (string.Equals(convertTo, "feet")){
                        Input();
                        ConvertMetresToFeet();
                        Output();
                    }
                    else{
                        Console.WriteLine("Invalid option.\n");
                    }
                }

                else if (string.Equals(convertFrom, "feet")){
                    ConvertTo();
                    if (string.Equals(convertTo, "miles")){
                        Input();
                        ConvertFeetToMiles();
                        Output();
                    }
                    else if (string.Equals(convertTo, "metres")){
                        Input();
                        ConvertFeetToMetres();
                        Output();
                    }
                    else{
                        Console.WriteLine("Invalid option.\n");
                    }
                }

                else if (string.Equals(convertFrom, "")){
                    exit = true;
                    Console.WriteLine("Exiting Converter...\n");
                }

                else{
                    Console.WriteLine("Invalid option.\n");
                }
            }
        }

        public void ConvertFrom()
        {
            Console.Write("Enter which unit you would like to convert from: miles, metres or feet. Or enter nothing to exit the converter: ");
            convertFrom = Console.ReadLine();
        }

        public void ConvertTo()
        {
            Console.Write("Enter which unit you would like to convert to: miles, metres or feet: ");
            convertTo = Console.ReadLine();
        }
        
        public void Input()
        {
            Console.Write("Please enter the number of " + convertFrom + ": ");
            inputValue = Convert.ToDouble(Console.ReadLine());
        }
        
        public void ConvertMilesToMetres()
        {
            outputValue = inputValue * miTOm;
        }

        public void ConvertMilesToFeet()
        {
            outputValue = inputValue * miTOf;
        }

        public void ConvertMetresToMiles()
        {
            outputValue = inputValue / miTOm;
        }

        public void ConvertMetresToFeet()
        {
            outputValue = inputValue * mTOf;
        }

        public void ConvertFeetToMiles()
        {
            outputValue = inputValue / miTOf;
        }

        public void ConvertFeetToMetres()
        {
            outputValue = inputValue / mTOf;
        }
        
        public void Output()
        {
            Console.WriteLine("There are " + outputValue + " " + convertFrom + " in " + inputValue + " " + convertTo + "\n");
        }
    }
}