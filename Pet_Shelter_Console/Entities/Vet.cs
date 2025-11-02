using Entities;

namespace Pet_Shelter_Console.Entities
{
    public class Vet : Employee
    {
        public Vet():base() 
        {
            EmployeeId = "Vet_Test";
            Name = "Vet Test";
            Salary = -1.00;
            EmployeeType = "Vet";
            Location = "Dummy Ave, Co Limerick, Ireland";
        }

        public Vet(string employeeId, string name, double salary, string employeeType, string location):base(employeeId, name, salary, employeeType, location)
        {

        }
    }
}
