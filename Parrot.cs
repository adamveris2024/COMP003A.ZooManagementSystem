namespace COMP003A.ZooManagementSystem
{
    internal class Parrot : Animal
    {
        public Parrot(string name, string species) : base(name, species)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("The parrot squawks!");
        }
    }
}