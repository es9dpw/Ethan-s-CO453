using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app converts different units of measurment
    /// </summary>
    /// <author>
    /// Ethan Smith
    /// </author>
    public class DistanceConverter
    {
        const double miTOf = 5280;
        const double miTOm = 1609.34;
        const double mTOf = (5280 / 1609.34);
        //defines the constant types and give them their value
        
        bool exit = false;
        string convertFrom;
        string convertTo;
        double inputValue;
        double outputValue;
        //defines the variable types

        public void Run()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("             App01: Distance Converter            ");
            Console.WriteLine("                  by Ethan Smith                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("            This is an app to convert             ");
            Console.WriteLine("           distances to different units           ");
            Console.WriteLine(" =================================================\n");
            //creates the heading for the app and displays it to the user
            
            while(exit == false){
            //creates a loop to keep the app running until the user manually exits it
                ConvertFrom();
                //calls the ConvertFrom method
            
                if (string.Equals(convertFrom, "miles")){
                //checks if the user entered miles for their converting from distance
                    ConvertTo();
                    //calls the ConvertTo method
                    if (string.Equals(convertTo, "metres")){
                    //checks if the user entered metres for their converting to distance
                        Input();
                        ConvertMilesToMetres();
                        Output();
                        //calls the three methods used for taking the distance input, calculating the new distance, and outputing the new distance
                    }
                    else if (string.Equals(convertTo, "feet")){
                    //checks if the user entered feet for their converting to distance
                        Input();
                        ConvertMilesToFeet();
                        Output();
                    }
                    else{
                        Console.WriteLine("Invalid option.\n");
                    }
                    //if neither of the other units are entered then an error is diplayed
                }
            
                else if (string.Equals(convertFrom, "metres")){
                //checks if the user entered metres for their converting from distance
                    ConvertTo();
                    if (string.Equals(convertTo, "miles")){
                    //checks if the user entered miles for their converting to distance
                        Input();
                        ConvertMetresToMiles();
                        Output();
                    }
                    else if (string.Equals(convertTo, "feet")){
                    //checks if the user entered feet for their converting to distance
                        Input();
                        ConvertMetresToFeet();
                        Output();
                    }
                    else{
                        Console.WriteLine("Invalid option.\n");
                    }
                }

                else if (string.Equals(convertFrom, "feet")){
                //checks if the user entered feet for their converting from distance
                    ConvertTo();
                    if (string.Equals(convertTo, "miles")){
                    //checks if the user entered miles for their converting to distance
                        Input();
                        ConvertFeetToMiles();
                        Output();
                    }
                    else if (string.Equals(convertTo, "metres")){
                    //checks if the user entered metres for their converting to distance
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
                //checks if the user enters nothing to exit the program and breaks the loop

                else{
                    Console.WriteLine("Invalid option.\n");
                }
                //if none of the unit options are entered then an error is diplayed
            }
        }

        public void ConvertFrom()
        {
            Console.Write("Enter which unit you would like to convert from: 'miles', 'metres' or 'feet'. Or enter nothing to exit the converter: ");
            convertFrom = Console.ReadLine();
        }
        //takes the users input on what distance unit they want to convert from

        public void ConvertTo()
        {
            Console.Write("Enter which unit you would like to convert to: 'miles', 'metres' or 'feet': ");
            convertTo = Console.ReadLine();
        }
        //takes the users input on what distance unit they want to convert to
        
        public void Input()
        {
            Console.Write("Please enter the number of " + convertFrom + ": ");
            inputValue = Convert.ToDouble(Console.ReadLine());
        }
        //asks the user to enter the distance in the units they asked to convert from
        
        public void ConvertMilesToMetres()
        {
            outputValue = inputValue * miTOm;
        }
        //converts the distance entered to the correct value in another unit depending on what the user entered

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
            Console.WriteLine("There are " + outputValue + " " + convertTo + " in " + inputValue + " " + convertFrom + "\n");
        }
        //outputs the new value with the units to the user
    }
}