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
    }
}
