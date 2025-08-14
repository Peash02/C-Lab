namespace VRS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Gixxer", "Suzuki", 69);
            v.display();
            Vehicle c = new Car("City", "Honda", 699,5,"Petrol");
            c.display();
        }
    }
}
