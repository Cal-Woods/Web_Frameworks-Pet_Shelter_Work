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
    }
}
