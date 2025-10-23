namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Pillow", 4000);
            p.display();
            Product e = new EProduct("Fridge", 69000, "Sony", 2);
            e.display();
            Product s = new Smartphone("15", 69690, "Apple", 6, "IOS", 512);
            s.display();
        }
    }
}
