using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankEx.Exceptions;

namespace BankEx
{
    internal class BankAcc
    {
        internal int balance;
        public BankAcc(int balance) 
        {
            this.balance = balance;
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to Withdraw:");
            int withd = int.Parse(Console.ReadLine());
            try
            {
                if (withd > balance)
                    throw new InsufficientFundsException();
                else
                {
                    balance = balance - withd;
                    Console.WriteLine($"Balance:{balance}");
                }

            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
