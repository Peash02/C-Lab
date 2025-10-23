using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PPS
{
    internal class Payment
    {
        public int Amount;
        public DateOnly date = new DateOnly();

        public Payment(int Amount , DateOnly date) 
        {
            this.Amount = Amount;
            this.date = date;
        }
        public virtual void display()
        {
            Console.WriteLine($"Amount:{Amount} Date : {date.ToShortDateString()}");
        }
    }
    class CreditCardPment : Payment
    {
        long CardNo;
        String CardHolderName;

        public CreditCardPment(int Amount,DateOnly date,long CardNo, String CardHolderName) : base(Amount,date)
        {
            this.Amount=Amount;
            this.date =date;
            this.CardNo = CardNo;
            this.CardHolderName = CardHolderName;
        }
        public override void display()
        {
            Console.WriteLine($"Amount:{Amount} Date : {date.ToShortDateString()} Card Number:{CardNo} Card Holder Name:{CardHolderName}");
        }

    }
    class UPIPayment : Payment
    {
        String UPIid;
        String BankName;

        public UPIPayment(int Amount,DateOnly date,String UPIid,String BankName) : base(Amount,date)
        {
            this.Amount = Amount;
            this.date = date;
            this.UPIid = UPIid;
            this.BankName = BankName;

        }
        public override void display()
        {
            Console.WriteLine($"Amount:{Amount} Date : {date.ToShortDateString()} UPI ID:{UPIid} Bank Name:{BankName }");
        }

    }
}
