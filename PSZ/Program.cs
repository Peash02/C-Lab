namespace PSZ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            pnz n = new pnz(num);
            n.check();
        }
    }
}
