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
    }
}
