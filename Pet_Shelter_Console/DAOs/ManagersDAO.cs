

using Entities;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAOs
{
    public class ManagersDAO
    {
        public ConnectionFacilitator connectionFacilitator {  get; private set; }
        public ManagersDAO(ConnectionFacilitator conn) 
        {
            if (conn == null) 
            {
                throw new ArgumentNullException("Given ConnectionFacilitator object was null! Please provide a valid ConnectionFacilitator!");
            }

            this.connectionFacilitator = conn;
        }

        public List<Manager> GetAllManagers()
        {
            if(connectionFacilitator.Connection.State == ConnectionState.Closed) 
            {
                return null;
            }
            List<Manager> managerList = new List<Manager>();

            try
            {
                MySqlCommand comm = new MySqlCommand("SELECT * FROM employees", connectionFacilitator.Connection);
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
    }
}
