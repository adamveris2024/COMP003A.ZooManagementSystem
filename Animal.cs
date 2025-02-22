namespace COMP003A.ZooManagementSystem
{
    abstract internal class Animal
    {
        private string _name;
        private string _species;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // Use the value parameter instead of Name property to prevent recursion.
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Animal's name is empty");
                }
                _name = value;
            }
        }

        public string Species
        {
            get
            {
                return _species;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Species' name is empty");
                }
                _species = value;
            }
        }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        // Abstract Method
        public abstract void MakeSound();
    }
}
