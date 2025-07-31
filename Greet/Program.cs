namespace Greet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            String name = Console.ReadLine();
            PP p = new PP(name);
            p.greet();
        }
    }
}
