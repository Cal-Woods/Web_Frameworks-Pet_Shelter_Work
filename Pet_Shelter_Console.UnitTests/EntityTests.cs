using Entities;

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
            Assert.AreEqual(manager.Location, "Dummy Lane, Co. Louth, Ireland");
        }
    }
}