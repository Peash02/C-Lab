using System.Security.Cryptography.X509Certificates;

namespace NumOp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num1;
            int num2;
            while (true)
            {
                Console.WriteLine("Choose your operation:");
                Thread.Sleep(1000);
                Console.WriteLine("1.Addition");
                Thread.Sleep(1000);
                Console.WriteLine("2.Subtraction");
                Thread.Sleep(1000);
                Console.WriteLine("3.Division");
                Thread.Sleep(1000);
                Console.WriteLine("4.Multiplication");
                Thread.Sleep(1000);
                Console.WriteLine("5.Exit");
                
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine("Enter Number 1:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Number 2:");
                    num2 = int.Parse(Console.ReadLine());
                    int sum = num1 + num2;
                    Console.WriteLine($"Sum is {sum}");
                }
                else if (x == 2)
                {
                    Console.WriteLine("Enter Number 1:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Number 2:");
                    num2 = int.Parse(Console.ReadLine());
                    int diff = num1 - num2;
                    Console.WriteLine($"Difference is {diff}");
                }
                else if (x == 3)
                {
                    try
                    {
                        Console.WriteLine("Enter Number 1:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number 2:");
                        num2 = int.Parse(Console.ReadLine());
                        float q = num1 / num2;
                        Console.WriteLine($"Quotient is {q}");

                    }
                    catch (DivideByZeroException e)
                    {

                        Console.WriteLine($"Error Occured:{ e.Message}");
                    }
                }
                else if ( x == 4)
                {
                    Console.WriteLine("Enter Number 1:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Number 2:");
                    num2 = int.Parse(Console.ReadLine());
                    int prod = num1 * num2;
                    Console.WriteLine($"Product is {prod}");
                }
                else if ( x == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invlaid Number!!");
                }
            }

        }
    }
}
