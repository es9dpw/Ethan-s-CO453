using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        bool exit = false;
        bool loggedIn = false;
        string menuChoice;
        public int postCount = -1;
        string user = "";

        public void Run()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("               App04: Social Network              ");
            Console.WriteLine("                  by Ethan Smith                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine("            This is an app to create             ");
            Console.WriteLine("         and view text and photo posts           ");
            Console.WriteLine(" =================================================\n");
            //creates the heading for the app and displays it to the user;

            while(exit == false){
                Menu();
                //calls the Menu method

                if (string.Equals(menuChoice, "1")){
                //checks if the entred the first menu option
                    Login();
                }
            }
        }
        
        public void Menu(){
            Console.Write("MAIN MENU\n1. log");
            if(loggedIn == false){
                Console.Write("in");
            }
            else if(loggedIn == true){
                Console.Write("out");
            }
            Console.Write("\n2. Add message post\n3. Add photo post\n4. Display all posts\n5. Display all posts by an author\n6. Exit App\n\nPlease enter your choice: ");
            menuChoice = Console.ReadLine();
        }
        //takes the users input on which menu option they want

        public void Login(){
            if(loggedIn == false){
                Console.Write("Enter your username to login: ");
                user = Console.ReadLine();
                loggedIn = true;
                Console.WriteLine(user + " logged in.");
            }
            else if(loggedIn == true){
                Console.Write("logging out...");
                loggedIn = false;
                user = "";
            }
        }
    }
}