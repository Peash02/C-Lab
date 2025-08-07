using DataEncapsulation;

namespace LabPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            Console.WriteLine("Enter Persons Name:");
            person1.Name = Console.ReadLine();
            Console.WriteLine($"Enter the Age of {person1.Name}:");
            person1.Age = int.Parse(Console.ReadLine());
            
            //person1.Name = "Alice";
            //person1.Age = 20;

            Console.WriteLine($"The Name is {person1.Name} and Age is {person1.Age}.");
        }
    }
}
