

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
    }
}
