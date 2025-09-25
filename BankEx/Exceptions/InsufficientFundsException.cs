﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEx.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() :base("Insufficent Balance!!!")
        {

        }
    }
}
