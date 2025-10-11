using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAOs
{
    public class ConnectionFacilitator
    {
        MySqlConnection connection;
        public ConnectionFacilitator(MySqlConnection conn)
        {
            if (conn == null)
            {
                throw new ArgumentNullException("MySql connection object was null, must be initialised!");
            }
            if (conn.ConnectionString == null)
            {
                throw new ArgumentNullException("MySql connection object connection string was not set, set connection string in format: 'server=url;uid=username;pwd=password;database=dbName'");
            }

            //Try to assign connection
            try
            {
                connection = conn;
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