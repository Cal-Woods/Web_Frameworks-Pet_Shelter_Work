using DAOs;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This is an application for a pet shelter management system! This system will allow managers to enter new animal records into system\nFor vets to be able to view these records.\nFosterers will be able to view animals that need a home and filter search results.");

        bool isRunning = true;
        string? menuChoice = "";

        const string SENTINEL = "exit";
        while (isRunning) {
            Console.WriteLine("\nPlease choose from the following options by typing a number:\n1) View all Employee records\n2) View All Animal records\n3) Add Employee to database\n4)Add Animal to database\nType 'exit' to exit program");
            menuChoice = Console.ReadLine();

            switch (menuChoice.ToLower()) 
            {
                case "1":
                    //TODO:Call method for corresponding action
                    break;

                case "2":
                    //TODO:Call method for corresponding action
                    break;

                case "3":
                    //TODO:Call method for corresponding action
                    break;

                case "4":
                    //TODO:Call method for corresponding action
                    break;

                case SENTINEL: //Stop while loop if SENTINEL value is typed
                    isRunning = false; //End loop to exit program
                    break;
                default: //All other cases
                    break; //While loop will just restart
            }
        }

        return;
    }
}