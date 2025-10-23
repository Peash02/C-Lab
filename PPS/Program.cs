using System.Data;

namespace PPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly datee = new DateOnly(2025,8,28);
            Payment p = new Payment(6000, datee);
            p.display();
            Payment c = new CreditCardPment(19000, datee, 1234567891011121,"Bitch");
            c.display();
            Payment u = new UPIPayment(69000, datee, "goal69@upi.com", "Big Bank");
            u.display();
        }
    }
}
