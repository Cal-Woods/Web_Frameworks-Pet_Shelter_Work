using DAOs;
using Entities;
using System.Data;

public class Program
{
    static List<Manager> managers = new List<Manager>();
    static List<Animal> animals = new List<Animal>();
    public static void Main(string[] args)
    {
        ConnectionFacilitator connect = new ConnectionFacilitator();

        Console.WriteLine("This is an application for a pet shelter management system! This system will allow managers to enter new animal records into system\nFor vets to be able to view these records.\nFosterers will be able to view animals that need a home and filter search results.");

        bool isRunning = true;
        string? menuChoice = "";

        const string SENTINEL = "exit";

        ManagersDAO dao = new ManagersDAO(new ConnectionFacilitator());

        while (isRunning)
        {
            Console.WriteLine("\nPlease choose from the following options by typing a number:\n1) View all Employee records\n2) View All Animal records\n3) Add Employee to database\n4)Add Animal to database\nType 'exit' to exit program");
            menuChoice = Console.ReadLine();

            switch (menuChoice.ToLower())
            {
                case "1":
                    managers = GetStoreManagers(dao);//Fetch & store managers records in list

                    if (managers.Count == 0)
                    {
                        Console.WriteLine("No managers available!");
                    }
                    else 
                    {
                        managers.ForEach(m => Console.WriteLine(m));//ForEach(Action<Manager> action) method iterates over the managers list & performs another method for each one
                    }
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
                    Console.WriteLine("Invalid option! Please read options.");
                    break; //While loop will just restart
            }
        }

        return;
    }

    private static List<Manager> GetStoreManagers(ManagersDAO managersDb)
    {
        if (managersDb == null)
        {
            Console.WriteLine("Given ManagersDAO object was null, please check passed parameter.");
            return new List<Manager>();
        }

        if (managers.Count == 0)
        {
            Console.WriteLine("The list of Managers is empty, fetching all manager records from database...");
            if(managersDb.connection.Connection.State == ConnectionState.Closed) 
            {
                Console.WriteLine("Connection to DB is down so unable to fetch list of managers.");

                return new List<Manager>();
            }

            managers = managersDb.GetAllManagers();
        }
        else
        {
            Console.Write("list is already populated.\nWould you like to fetch from database anyway?(y/n) ");
            if (Console.Read().Equals("y"))
            {
                managers = managersDb.GetAllManagers();
            }
            else
            {
                Console.WriteLine("Done.");
            }

            Console.ReadLine();//Clear buffer
        }

        return managers;
    }

    private static List<Animal> GetStoreAnimals(AnimalsDAO dao) 
    {
        if (dao == null) 
        {
            Console.WriteLine("Cannot reach database at the moment. Try again later.");
            return new List<Animal>();
        }

        List<Animal> animals = dao.GetAllAnimals();

        return animals;
    }
}