namespace BankEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcc b = new BankAcc(5000);
            b.Withdraw();

        }
    }
}

