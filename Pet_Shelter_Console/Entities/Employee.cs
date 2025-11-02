namespace Entities
{
    public abstract class Employee
    {
        private string employeeId;
        private string name;
        private double salary;
        private string employeeType;
        private string location;
        public string EmployeeId {
            get { return employeeId; } 
            set { employeeId = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary 
        {
            get { return salary; }
            set { salary = value; }
        }
        public string EmployeeType 
        {
            get { return employeeType; }
            set { employeeType = value; }
        }
        public string Location 
        {
            get { return location; }
            set { location = value; }
        }

        /// <summary>
        /// A no parameter constructor that instantiates test properties for an employee.
        /// </summary>
        /// <remarks>Not to be used in production!</remarks>
        public Employee() 
        {
            EmployeeId = "-1";
            Name = "Dummy Manager object for testing, change all values before production usage!";
            Salary = -1.00;
            EmployeeType = "Test";
            Location = "Dummy Lane, Co. Louth, Ireland";
        }
        public Employee(string employeeId, string name, double salary, string employeeType, string location)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
            EmployeeType = employeeType;
            Location = location;
        }

        public override string ToString() 
        {
            return $"EmployeeId: {EmployeeId}\nName: {Name}\nSalary(Euro): {Salary}\nEmployee type:{EmployeeType}\nLocation: {Location}";
        }
    }
}
