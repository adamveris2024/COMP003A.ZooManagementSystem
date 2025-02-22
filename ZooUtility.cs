namespace COMP003A.ZooManagementSystem
{
    internal class ZooUtility
    {
        public static void DescribeAnimal(string name)
        {
            Console.WriteLine($"Animal Name: {name}");
        }
        public static void DescribeAnimal(string name, string species)
        {
            Console.WriteLine($"Animal Name: {name}, Animal Species: {species}");
        }
        public static void DescribeAnimal(string name, string species, int age)
        {
            Console.WriteLine($"Animal Name: {name}, Animal Species: {species}, Age: {age}");
        }
    }
}