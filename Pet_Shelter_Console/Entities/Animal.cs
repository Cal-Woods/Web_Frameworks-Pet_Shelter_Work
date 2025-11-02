using Entities.Enums;

namespace Entities
{
    public class Animal
    {
        private string animalId;
        private string name;
        private int age;
        private double height;
        private double width;
        private char sex;
        private Species species;
        private string vaccinationStatus;
        private string isAdopted;
        public string AnimalId
        {
            get { return animalId; }
            private set { animalId = value; }
        }
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
            set { species = Enum.Parse<Species>(value); }
        }
        public string VaccinationStatus
        {
            get { return vaccinationStatus; }
            set => Boolean.Parse(value).ToString();
        }
        public string IsAdopted
        {
            get { return isAdopted; }
            set => Boolean.Parse(value).ToString();
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
            VaccinationStatus = "true";
            IsAdopted = "false";
        }
        /// <summary>
        /// A parameterised constructor to set each Animal attribute to given values.
        /// </summary>
        /// <param name="name">Given name</param>
        /// <param name="age">Given age</param>
        /// <param name="height">Given height</param>
        /// <param name="width">Given width</param>
        /// <param name="sex">Given sex {'m','f'}</param>
        /// <param name="vaccinationStatus">Given vaccination status{'true','false'}</param>
        /// <param name="isAdopted">Given adoption status{'true', 'false'}</param>
        /// <remarks>Certain values like <paramref name="species">species</paramref>, <paramref name="vaccinationStatus">vaccinationStatus</paramref> and <paramref name="isAdopted">isAdopted</paramref> must take valid values specified in documentation</remarks>
        public Animal(string animalId, string name, int age, double height, double width, char sex, string species, string vaccinationStatus, string isAdopted)
        {
            AnimalId = animalId;
            Name = name;
            Age = age;
            Height = height;
            Width = width;
            Sex = sex;
            Species = species.ToUpper();
            VaccinationStatus = Boolean.Parse(vaccinationStatus).ToString();
            IsAdopted = Boolean.Parse(isAdopted).ToString();
        }

        public override string ToString() {
            return $"Animal id: {AnimalId}\nName: {Name}\nAge: {Age}\nWidth: {Width}\nHeight: {Height}\nSex: {Sex}\nVaccination status: {VaccinationStatus}\n";
        }
    }
}