

using Entities;
using MySql.Data.MySqlClient;
using System.Collections;

namespace DAOs
{
    public class ManagersDAO
    {
        private ConnectionFacilitator connectionFacilitator;
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
