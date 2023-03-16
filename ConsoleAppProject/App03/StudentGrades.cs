using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;
using System.Collections;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This app allows the user to enter students and their marks to calculate their grades.
    /// They can then also display all the students with their marks and their grades, display the average, minimum and maximum marks, and display a grade profile.
    /// </summary>
    /// <author>
    /// Ethan Smith
    /// </author>
    public class StudentGrades
    {
        bool exit = false;
        bool validMark;
        string menuChoice;
        string markHolder;
        int studentCount = -1;
        int listCount;
        int aNumber;
        int bNumber;
        int cNumber;
        int dNumber;
        int fNumber;
        double totalMarks;
        double meanMark;
        double minMark;
        double maxMark;
        ArrayList students = new ArrayList();
        ArrayList marks = new ArrayList();
        ArrayList grades = new ArrayList();
        //defines the variable types

        public void Run()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("              App03: Grade Calculator             ");
            Console.WriteLine("                  by Ethan Smith                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("            This is an app to convert             ");
            Console.WriteLine("            students marks to grades              ");
            Console.WriteLine(" =================================================\n");
            //creates the heading for the app and displays it to the user

            while(exit == false){
                Menu();
                //calls the Menu method

                if (string.Equals(menuChoice, "1")){
                //checks if the entred the first menu option
                    studentCount++;
                    AddStudent();
                    AddMark();
                    AddGrade();
                    //adds 1 to the student count and calls the method for adding a student's name, mark and grade
                }

                else if (string.Equals(menuChoice, "2")){
                //checks if the entred the second menu option
                    ListDisplay();
                    //calls the ListDisplay method
                }
                
                else if (string.Equals(menuChoice, "3")){
                //checks if the entred the third menu option
                    MeanMark();
                    MinMaxMark();
                    //calls the methods for calculating the mean, minimum and maximum marks
                }
                
                else if (string.Equals(menuChoice, "4")){
                //checks if the entred the fourth menu option
                    GradeProfile();
                    //calls the GradeProfile method
                }
                
                else if (string.Equals(menuChoice, "5")){
                //checks if the entred the fifth menu option
                    exit = true;
                    Console.WriteLine("Exiting App...\n");
                    //breaks the apps loop to exit the app
                }

                else{
                    Console.WriteLine("Invalid option.\n");
                }
                //if none of the unit type options are entered then an error is diplayed
            }
        }

        public void Menu(){
            Console.Write("MAIN MENU\n1. Add Student and Mark\n2. Display student, mark and grade list\n3. Display average, minimum and maximum marks\n4. Display Grade Profile\n5. Exit App\n\nPlease enter your choice: ");
            menuChoice = Console.ReadLine();
        }
        //takes the users input on which menu option they want

        public void AddStudent(){
            Console.Write("Enter the name of the student: ");
            students.Add(Console.ReadLine());
        }
        //takes the users input to add a student's name to an array list

        public void AddMark(){
            validMark = false;
            while (validMark == false){
                Console.Write("Enter the student's mark: ");
                markHolder = Console.ReadLine();
                if((Convert.ToDouble(markHolder) >= 0) && (Convert.ToDouble(markHolder) <= 100)){
                    marks.Add(markHolder);
                    validMark = true;
                }
                else{
                    Console.WriteLine("Invalid mark, please re-enter.");
                }
            }
        }
        //takes the users input to add a student's mark to an array list and checks that they entered a vlid grade

        public void AddGrade(){
            if(Convert.ToDouble(marks[studentCount]) >= 70){
                grades.Add("A");
            }
            else if ((Convert.ToDouble(marks[studentCount]) >= 60) && (Convert.ToDouble(marks[studentCount]) < 70)){
                grades.Add("B");
            }
            else if ((Convert.ToDouble(marks[studentCount]) >= 50) && (Convert.ToDouble(marks[studentCount]) < 60)){
                grades.Add("C");
            }
            else if ((Convert.ToDouble(marks[studentCount]) >= 40) && (Convert.ToDouble(marks[studentCount]) < 50)){
                grades.Add("D");
            }
            else if (Convert.ToDouble(marks[studentCount]) < 40){
                grades.Add("F");
            }
            Console.WriteLine(students[studentCount] + " got a grade " + grades[studentCount] + ".\n");
        }
        //calculates a student's grade based on their mark, adds it to an array, then displays it back to the user

        public void ListDisplay(){
            if(studentCount <= -1){
                Console.WriteLine("No student's marks have been entered.\n");
            }
            else{
                listCount = -1;
                while(listCount < studentCount){
                    listCount++;
                    Console.WriteLine("Student: " + students[listCount] + ", Mark: " + marks[listCount] + ", Grade: " + grades[listCount]);
                }
                Console.WriteLine("");
            }
        }
        //Displays each element in the lists to display a list of students with their mark and grades to the user

        public void MeanMark(){
            if(studentCount <= -1){
                Console.WriteLine("No student's marks have been entered.\n");
            }
            else{
                listCount = -1;
                totalMarks = 0;
                while(listCount < studentCount){
                    listCount++;
                    totalMarks = totalMarks + Convert.ToDouble(marks[listCount]);
                }
                meanMark = totalMarks / (studentCount + 1);
                Console.WriteLine("The average mark is " + meanMark + ".");
            }
        }
        //Calculates the total marks of every student and then divides by the number of students to find the average mark

        public void MinMaxMark(){
            if(studentCount <= -1){
                Console.WriteLine("No student's marks have been entered.\n");
            }
            else if(studentCount == 0){
                Console.WriteLine("The minimum mark is " + Convert.ToDouble(marks[(studentCount)]) + ".");
                Console.WriteLine("The maximum mark is " + Convert.ToDouble(marks[(studentCount)]) + ".\n");
            }
            else{
                listCount = -1;
                minMark = Convert.ToDouble(marks[(listCount + 1)]);
                maxMark = Convert.ToDouble(marks[(listCount + 1)]);
                while(listCount < (studentCount - 1)){
                    listCount++;
                    if (Convert.ToDouble(marks[(listCount + 1)]) < Convert.ToDouble(marks[listCount])){
                        minMark = Convert.ToDouble(marks[(listCount + 1)]);
                    }
                    else if (Convert.ToDouble(marks[(listCount + 1)]) > Convert.ToDouble(marks[listCount])){
                        maxMark = Convert.ToDouble(marks[(listCount + 1)]);
                    }
                }
                Console.WriteLine("The minimum mark is " + minMark + ".");
                Console.WriteLine("The maximum mark is " + maxMark + ".\n");
            }
        }
        //Checks through each mark to see which mark is the lowest and highest and displays them back to the user

        public void GradeProfile(){
            if(studentCount <= -1){
                Console.WriteLine("No student's marks have been entered.\n");
            }
            else{
                listCount = -1;
                aNumber = 0;
                bNumber = 0;
                cNumber = 0;
                dNumber = 0;
                fNumber = 0;
                while(listCount < studentCount){
                    listCount++;
                    if(string.Equals(grades[listCount], "A")){
                    aNumber++;
                    }
                    else if(string.Equals(grades[listCount], "B")){
                    bNumber++;
                    }
                    else if(string.Equals(grades[listCount], "C")){
                    cNumber++;
                    }
                    else if(string.Equals(grades[listCount], "D")){
                    dNumber++;
                    }
                    else if(string.Equals(grades[listCount], "F")){
                    fNumber++;
                    }
                }
                Console.WriteLine(((aNumber * 100) / (studentCount + 1)) + "% of students got an A grade, " + ((bNumber * 100) / (studentCount + 1)) + "% of students got a B grade, " + ((cNumber * 100) / (studentCount + 1)) + "% of students got a C grade, " + ((dNumber * 100) / (studentCount + 1)) + "% of students got a D grade, and " + ((fNumber * 100) / (studentCount + 1)) + "% of students got an F grade.\n");
            }
        }
        //Calculates the percentage of students who got each grade and displays it to the user
    }
}