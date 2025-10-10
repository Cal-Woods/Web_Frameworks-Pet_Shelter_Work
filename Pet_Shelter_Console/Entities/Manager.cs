namespace Entities
{
    public class Manager : Employee
    {

        /// <summary>
        /// No parameter constructor to call base constructor Employee, that sets all attributes to dummy values!
        /// </summary>
        public Manager() : base()
        {
        }

        /// <summary>
        /// A parameterised constructor for instantiating a Manager object with given values!
        /// </summary>
        /// <param name="employeeId">Given employee id of manager</param>
        /// <param name="name">Given name of manager</param>
        /// <param name="salary">Given pay of manager</param>
        /// <param name="employeeType">Given type of manager</param>
        /// <param name="location">Given location of manager</param>
        public Manager(string employeeId, string name, double salary, string employeeType, string location) : base(employeeId, name, salary, employeeType, location)
        {
        }
    }
}
