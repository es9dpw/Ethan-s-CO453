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
        double miles = 1;
        double feet = 1;
        double metres = 1;

        public void Run()
        {
            while(exit == false){
                ConvertFrom();
            
                if (string.Equals(convertFrom, "Miles")){
                    ConvertTo();
                    if (string.Equals(convertTo, "Metres")){
                        InputMiles();
                        ConvertMiles();
                        OutputMilesToMetres();
                    }
                    else if (string.Equals(convertTo, "Feet")){
                        InputMiles();
                        ConvertMiles();
                        OutputMilesToFeet();
                    }
                    else{
                        Console.Write("\nInvalid option. ");
                    }
                }
            
                else if (string.Equals(convertFrom, "Metres")){
                    ConvertTo();
                    if (string.Equals(convertTo, "Miles")){
                        InputMetres();
                        ConvertMetres();
                        OutputMetresToMiles();
                    }
                    else if (string.Equals(convertTo, "Feet")){
                        InputMetres();
                        ConvertMetres();
                        OutputMetresToFeet();
                    }
                    else{
                        Console.Write("\nInvalid option. ");
                    }
                }

                else if (string.Equals(convertFrom, "Feet")){
                    ConvertTo();
                    if (string.Equals(convertTo, "Miles")){
                        InputFeet();
                        ConvertFeet();
                        OutputFeetToMiles();
                    }
                    else if (string.Equals(convertTo, "Metres")){
                        InputFeet();
                        ConvertFeet();
                        OutputFeetToMetres();
                    }
                    else{
                        Console.Write("\nInvalid option. ");
                    }
                }

                else if (string.Equals(convertFrom, "")){
                    exit = true;
                    Console.WriteLine("Exiting Converter\n");
                }

                else{
                    Console.Write("\nInvalid option. ");
                }
            }
        }

        public void ConvertFrom()
        {
            Console.Write("Enter which unit you would like to convert from: Miles, Metres or Feet. Or enter nothing to exit the converter: ");
            convertFrom = Console.ReadLine();
        }

        public void ConvertTo()
        {
            Console.Write("Enter which unit you would like to convert to: Miles, Metres or Feet: ");
            convertTo = Console.ReadLine();
        }
        
        public void InputMiles()
        {
            Console.Write("Please enter the number of miles: ");
            miles = Convert.ToDouble(Console.ReadLine());
        }
        
        public void InputMetres()
        {
            Console.Write("Please enter the number of metres: ");
            metres = Convert.ToDouble(Console.ReadLine());
        }

        public void InputFeet()
        {
            Console.Write("Please enter the number of feet: ");
            feet = Convert.ToDouble(Console.ReadLine());
        }
        
        public void ConvertMiles()
        {
            metres = miles * miTOm;
            feet = miles * miTOf;
        }

        public void ConvertMetres()
        {
            miles = metres / miTOm;
            feet = metres * mTOf;
        }

        public void ConvertFeet()
        {
            miles = feet / miTOf;
            metres = feet / mTOf;
        }
        
        public void OutputMilesToMetres()
        {
            Console.WriteLine("There are " + metres + " metres in " + miles + " miles.\n");
        }
        
        public void OutputMilesToFeet()
        {
            Console.WriteLine("There are " + feet + " feet in " + miles + " miles.\n");
        }

        public void OutputMetresToMiles()
        {
            Console.WriteLine("There are " + miles + " miles in " + metres + " metres.\n");
        }
        
        public void OutputMetresToFeet()
        {
            Console.WriteLine("There are " + feet + " feet in " + metres + " metres.\n");
        }

        public void OutputFeetToMiles()
        {
            Console.WriteLine("There are " + miles + " miles in " + feet + " feet.\n");
        }

        public void OutputFeetToMetres()
        {
            Console.WriteLine("There are " + metres + " metres in " + feet + " feet.\n");
        }
    }
}