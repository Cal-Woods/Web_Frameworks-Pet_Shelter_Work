namespace Entities
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private double height;
        private double width;
        private char sex;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }
    }
}