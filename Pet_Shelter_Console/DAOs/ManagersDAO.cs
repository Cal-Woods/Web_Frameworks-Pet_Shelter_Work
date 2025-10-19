using Entities;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAOs
{
    public class ManagersDAO : IDAO
    {
        public ConnectionFacilitator connection {  get; private set; }
        public ManagersDAO(ConnectionFacilitator conn) 
        {
            if (conn == null) 
            {
                throw new ArgumentNullException("Given ConnectionFacilitator object was null! Please provide a valid ConnectionFacilitator!");
            }

            this.connection = conn;
        }

        public List<Manager> GetAllManagers()
        {
            if(connection.Connection.State == ConnectionState.Closed) 
            {
                return null;
            }
            List<Manager> managerList = new List<Manager>();

            try
            {
                MySqlCommand comm = new MySqlCommand("SELECT * FROM employees", connection.Connection);
                try
                {

                    MySqlDataReader data = comm.ExecuteReader();

                    while (data.Read())
                    {
                        managerList.Add(new Manager(data[0].ToString(), data[1].ToString(), Double.Parse(data[2].ToString()), data[3].ToString(), data[4].ToString()));
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

            return managerList;
        }

        public Manager getManagerById(string id)
        {
            //Validation
            ArgumentNullException.ThrowIfNull(id, id);
            if (connection.Connection.State != ConnectionState.Open)
            {
                return new Manager();
            }

            Manager manager = null;

            try
            {
                MySqlCommand comm = new MySqlCommand("SELECT * FROM employees WHERE employeeId = @id");
                comm.Parameters.AddWithValue("@id", id);

                try
                {
                    MySqlDataReader data = comm.ExecuteReader();

                    if (data.Read())
                    {
                        manager = new Manager(data[0].ToString(), data[1].ToString(), Double.Parse(data[2].ToString()), data[3].ToString(), data[4].ToString());
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

            return manager;
        }
    }
}
