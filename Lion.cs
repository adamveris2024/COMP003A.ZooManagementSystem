namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {
        public Lion(string name, string species) : base(name, species)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("The lion roars!");
        }
    }
}