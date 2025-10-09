namespace Entities
{
    public class Manager
    {
        private int managerId;
        private string name;
        private double pay;

        public int ManagerId
        {
            get { return managerId; }
            set { managerId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Pay
        {
            get { return pay; }
            set { pay = value; }
        }
        /// <summary>
        /// No parameter constructor that sets all attributes to dummy values!
        /// </summary>
        public Manager()
        {
            ManagerId = -1;
            Name = "Dummy Manager object for testing, change all values before production usage!";
            Pay = -1.00;

        }

        /// <summary>
        /// A parameterised constructor for instantiating a Manager object with given values!
        /// </summary>
        /// <param name="managerId">Given manager id</param>
        /// <param name="name">Given name</param>
        /// <param name="pay">Given pay of manager</param>
        public Manager(int managerId, string name, double pay)
        {
            ManagerId = managerId;
            Name = name;
            Pay = pay;
        }
    }
}
