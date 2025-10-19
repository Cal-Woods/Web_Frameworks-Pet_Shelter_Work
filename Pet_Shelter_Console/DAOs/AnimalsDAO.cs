using Entities;
using MySql.Data.MySqlClient;
using System.Data;

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
    }
}
