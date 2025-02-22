namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            while (true)
            {
                Console.WriteLine("Welcome to the Zoo Management System!\n");
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit\n");

                Console.Write("Your choice: ");
                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    // Check for valid input early.
                    if (choice < 1 || choice > 5)
                    {
                        Console.WriteLine("Invalid input. Please try again.\n");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the name of the lion: ");
                            string lionName = Console.ReadLine();
                            Console.Write("Enter the species of the lion: ");
                            string lionSpecies = Console.ReadLine();
                            Lion lion = new Lion(lionName, lionSpecies);
                            Animals.Add(lion);
                            Console.WriteLine("Lion added successfully!\n");
                            break;
                        case 2:
                            Console.Write("Enter the name of the parrot: ");
                            string parrotName = Console.ReadLine();
                            Console.Write("Enter the species of the parrot: ");
                            string parrotSpecies = Console.ReadLine();
                            Parrot parrot = new Parrot(parrotName, parrotSpecies);
                            Animals.Add(parrot);
                            Console.WriteLine("Parrot added successfully!\n");
                            break;
                        case 3:
                            if (Animals.Count == 0)
                            {
                                Console.WriteLine("There are no animals saved.\n");
                            }
                            else
                            {
                                foreach (Animal animal in Animals)
                                {
                                    animal.MakeSound();
                                    Console.WriteLine($"({animal.Name}, {animal.Species})");
                                }
                                Console.WriteLine(); // for spacing
                            }
                            break;
                        case 4:
                            
                            Console.WriteLine("DescribeAnimal (name only):");
                            ZooUtility.DescribeAnimal("");
                            Console.WriteLine("DescribeAnimal (name and species):");
                            ZooUtility.DescribeAnimal("", "");
                            Console.WriteLine("DescribeAnimal (name, species, and age):");
                            ZooUtility.DescribeAnimal("", "", 12);
                            Console.WriteLine(); // for spacing
                            break;
                        case 5:
                            Console.WriteLine("Goodbye!");
                            return; // Exit the Main method.
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}. Please try again.\n");
                }
            }
        }
    }
}
