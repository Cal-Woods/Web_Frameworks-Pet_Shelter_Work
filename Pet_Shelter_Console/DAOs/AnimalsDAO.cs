using Entities;
using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace DAOs
{
    public class AnimalsDAO : IDAO
    {
        public ConnectionFacilitator connection { get; private set; }
        public AnimalsDAO(ConnectionFacilitator connectionFacilitator)
        {
            ArgumentNullException.ThrowIfNull(connectionFacilitator, "connectionFacilitator");

            connection = connectionFacilitator;
        }

        public List<Animal> GetAllAnimals()
        {
            if (connection.Connection.State == ConnectionState.Closed)
            {
                return new List<Animal>();
            }

            List<Animal> animalList = new List<Animal>();

            try
            {
                MySqlCommand comm = new MySqlCommand("SELECT * FROM animals", connection.Connection);
                try
                {

                    MySqlDataReader data = comm.ExecuteReader();

                    while (data.Read())
                    {
                        animalList.Add(new Animal(data[0].ToString(), data[1].ToString(), Int32.Parse(data[2].ToString()), Double.Parse(data[3].ToString()), Double.Parse(data[4].ToString()), data[5].ToString()[0], data[6].ToString()));
                    }

                    data.Close();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine("2nd catch\n" + e.Message);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("1st catch\n" + ex.Message);
            }

            return animalList;
        }

        public Animal GetAnimalById(string id)
        {
            //Validation
            ArgumentNullException.ThrowIfNull(id, id);
            if (connection.Connection.State != ConnectionState.Open)
            {
                return new Animal();
            }

            Animal animal = null;

            try
            {
                MySqlCommand comm = new MySqlCommand("SELECT * FROM animals WHERE animalId = @id;", connection.Connection);
                comm.Parameters.AddWithValue("@id", id);

                try
                {
                    MySqlDataReader data = comm.ExecuteReader();

                    if (data.Read())
                    {
                        animal = new Animal(data[0].ToString(), data[1].ToString(), Int32.Parse(data[2].ToString()), Double.Parse(data[3].ToString()), Double.Parse(data[4].ToString()), data[5].ToString()[0], data[6].ToString());
                    }

                    data.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return animal;
        }

        public bool InsertAnimal(Animal animal)
        {
            ArgumentNullException.ThrowIfNull(animal, "animal");

            int result = -1;
            try
            {
                MySqlCommand comm = new MySqlCommand("INSERT INTO animals VALUES(@t1, @t2, @t3, @t4, @t5, @t6, @t7)");
                comm.Parameters.AddWithValue("@t1", animal.AnimalId);
                comm.Parameters.AddWithValue("@t2", animal.Name);
                comm.Parameters.AddWithValue("@t3", animal.Age);
                comm.Parameters.AddWithValue("@t4", animal.Height);
                comm.Parameters.AddWithValue("@t5", animal.Width);
                comm.Parameters.AddWithValue("@t6", animal.Sex);
                comm.Parameters.AddWithValue("@t7", animal.Species);

                try
                {
                    result = comm.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result > 0;
        }
    }
}
