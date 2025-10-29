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

        AnimalsDAO dAO = new AnimalsDAO(connect);

        while (isRunning)
        {
            Console.WriteLine("\nPlease choose from the following options by typing a number:\n1) View all Employee records\n2) View All Animal records\n3) Add Employee to database\n4)Add Animal to database\nType 'exit' to exit program");
            menuChoice = Console.ReadLine();

            switch (menuChoice.ToLower())
            {
                case "1":
                    managers = GetStoreManagers(new ManagersDAO(connect));//Fetch & store managers records in list

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
                    animals = GetStoreAnimals(new AnimalsDAO(connect));

                    if (animals.Count == 0) 
                    {
                        Console.WriteLine("No animals available!");
                    }
                    else
                    {
                        animals.ForEach(a => Console.WriteLine(a));
                    }
                    break;

                case "3":
                    Console.Write("Enter animal id: ");
                    Animal a = dAO.GetAnimalById(Console.ReadLine());

                    if (a == null) 
                    {
                        Console.WriteLine("There is no entry with that id.");
                        break;
                    }

                    Console.WriteLine("Found match!\n\n"+a);
                    break;

                case "4":
                    bool inserted = InsertAnimal(dAO);

                    if(inserted == true)
                    {
                        Console.WriteLine("Animal record inserted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("There was a problem inserting animal record into database. Check for duplicate id or invalid species!");
                    }
                    break;

                case SENTINEL: //Stop while loop if SENTINEL value is typed
                    isRunning = false; //End loop to exit program
                    break;
                default: //All other cases
                    Console.WriteLine("Invalid option! Please read options.");
                    break; //While loop will just restart
            }
        }

        connect.CloseConnection();
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

    private static Animal GetAnimalById(AnimalsDAO dao, string id)
    {
        ArgumentNullException.ThrowIfNull(dao, "dao");
        ArgumentNullException.ThrowIfNullOrWhiteSpace(id, "id");

        if(Int32.Parse(id) < 0)
        {
            Console.WriteLine($"Invalid, given id was {id}, cannot be less than 0.");
        }

        Animal animal = dao.GetAnimalById(id);

        return animal;
    }
    private static bool InsertAnimal(AnimalsDAO dao)
    {
        ArgumentNullException.ThrowIfNull(dao, "dao");

        string[] animalInfo = new string[7];

        Console.WriteLine("Please fill out animal information to insert animal record into system:");

        Console.Write("Enter an id for animal(Will fail if id already exists): ");
        animalInfo[0] = Console.ReadLine();

        Console.Write("Enter animals name: ");
        animalInfo[1] = Console.ReadLine();

        Console.Write("Enter animals age: ");
        animalInfo[2] = Console.ReadLine();

        Console.Write("Enter animal's height: ");
        animalInfo[3] = Console.ReadLine();

        Console.Write("Enter animal's width: ");
        animalInfo[4] = Console.ReadLine();

        Console.Write("Enter animal's sex(m, f): ");
        animalInfo[5] = Console.ReadLine();

        Console.Write("Enter animal's species(Must be a valid species in database): ");
        animalInfo[6] = Console.ReadLine();

        Animal animal = new Animal(animalInfo[0], animalInfo[1], Int32.Parse(animalInfo[2]), Double.Parse(animalInfo[3]), Double.Parse(animalInfo[4]), animalInfo[5][0], animalInfo[6]);
        bool result = dao.InsertAnimal(animal);

        return result;
    }
}