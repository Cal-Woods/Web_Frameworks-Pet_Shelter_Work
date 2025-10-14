using DAOs;
using Entities;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;
using System;
using System.Data;

public class Program
{
    private static List<Manager> list;
    public static void Main(string[] args)
    {
        Console.WriteLine("This is an application for a pet shelter management system! This system will allow managers to enter new animal records into system\nFor vets to be able to view these records.\nFosterers will be able to view animals that need a home and filter search results.");

        bool isRunning = true;
        string? menuChoice = "";

        const string SENTINEL = "exit";

        ManagersDAO dao = new ManagersDAO(new ConnectionFacilitator());

        list = StoreManagers(dao);

        while (isRunning)
        {
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

    private static List<Manager> StoreManagers(ManagersDAO managersDb)
    {
        if (managersDb == null)
        {
            throw new ArgumentNullException("Given ManagersDAO object was null, please check passed parameter.");
        }

        if (list.Count == 0)
        {
            Console.WriteLine("The list of Managers is empty, fetching all manager records from database...");
            list = managersDb.GetAllManagers();
        }
        else
        {
            Console.Write("list is already populated.\nWould you like to fetch from database anyway?(y/n) ");
            if (Console.Read().Equals("y"))
            {
                list = managersDb.GetAllManagers();
            }
            else
            {
                Console.WriteLine("Done.");
            }
        }

        return list;
    }
}