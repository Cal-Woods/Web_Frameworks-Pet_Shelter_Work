using Entities.Enums;

namespace Entities
{
    public class Animal
    {
        private string name;
        private int age;
        private double height;
        private double width;
        private char sex;
        private Species species;

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
        public string Species
        {
            get { return species.ToString(); }
            set { species = Enum.Parse<Species>(value); }//TODO: Change to lambda expression that checks value matches Species Enums.
        }

        /// <summary>
        /// A no parameter constructor.
        /// </summary>
        /// <remarks>In Sex field, 'U' stands for Unknown</remarks>
        public Animal()
        {
            Name = "Dummy";
            Age = -1;
            Height = -1;
            Width = -1;
            Sex = 'U';
            Species = "Dog".ToUpper();
        }
        /// <summary>
        /// A parameterised constructor to set each Animal attribute to given values.
        /// </summary>
        /// <param name="name">Given name</param>
        /// <param name="age">Given age</param>
        /// <param name="height">Given height</param>
        /// <param name="width">Given width</param>
        /// <param name="sex">Given sex {'m','f'}</param>
        public Animal(string name, int age, double height, double width, char sex, string species)
        {
            Name = name;
            Age = age;
            Height = height;
            Width = width;
            Sex = sex;
            Species = species.ToUpper();
        }

        public override string ToString() {
            return $"Name: {Name}\nAge: {Age}\nWidth: {Width}\nHeight: {Height}\nSex: {Sex}";
        }
    }
}