using Entities;
using Pet_Shelter_Console.Entities;

namespace Pet_Shelter_Console.UnitTests

{
    public class EntityTests
    {
        [SetUp]
        public void Setup()
        {
        }

    [Test]
    public void InstantiateManagerWithNoArgsConstructorContainsCorrectValues()
        {
            Manager manager = new Manager();

            Assert.AreEqual(manager.EmployeeId, "-1");
            Assert.AreEqual(manager.Name, "Dummy Manager object for testing, change all values before production usage!");
            Assert.AreEqual(manager.Salary, -1.00);
            Assert.AreEqual(manager.EmployeeType, "Test");
            Assert.AreEqual(manager.Location, "Dummy Lane, Co. Louth, Ireland");
        }

        [Test]
        public void InstantiateManagerWithValidAllArgsConstructorSuccessful()
        {
            Manager manager = new Manager("first_managerAllArgs_test", "Dalton Reynolds", 45000.55, "Manager", "Drogheda, Co Louth, Ireland");

            Assert.AreEqual(manager.EmployeeId, "first_managerAllArgs_test");
            Assert.AreEqual(manager.Name, "Dalton Reynolds");
            Assert.AreEqual(manager.Salary, 45000.55);
            Assert.AreEqual(manager.EmployeeType, "Manager");
            Assert.AreEqual(manager.Location, "Drogheda, Co Louth, Ireland");
        }

        [Test]
        public void InstantiateVetWithNoArgsConstructorContainsCorrectValues()
        {
            Vet vet = new Vet();

            Assert.AreEqual(vet.EmployeeId, "Vet_Test");
            Assert.AreEqual(vet.Name, "Vet Test");
            Assert.AreEqual(vet.Salary, -1.00);
            Assert.AreEqual(vet.EmployeeType, "Vet");
            Assert.AreEqual(vet.Location, "Dummy Ave, Co Limerick, Ireland");
        }

        [Test]
        public void InstantiateVetWithAllArgsConstructorSuccessful()
        {
            Vet vet = new Vet("second_test", "Casey Duffy", 75000.78, "Vet", "Co Dundalk, Ireland");

            Assert.AreEqual(vet.EmployeeId, "second_test");
            Assert.AreEqual(vet.Name, "Casey Duffy");
            Assert.AreEqual(vet.Salary, 75000.78);
            Assert.AreEqual(vet.EmployeeType, "Vet");
            Assert.AreEqual(vet.Location, "Co Dundalk, Ireland");
        }
    }
}