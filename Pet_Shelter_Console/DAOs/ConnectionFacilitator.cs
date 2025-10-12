using MySql.Data;
using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;

namespace DAOs
{
    public class ConnectionFacilitator
    {
        private const string DETAILS = "server=localhost;uid=root;pwd=;database=Pet_Shelter";

        MySqlConnection connection;
        public ConnectionFacilitator()
        {
            //Try to assign connection
            try
            {
                connection = new MySqlConnection(DETAILS);
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Connection to db could not be established, check given MySqlConnection object or sql database!\n"+e.Message);
            }
        }

        public MySqlConnection Connection
        {
            get { return connection; }
            private set { connection = value; }
        }
    }
}