using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Exceptions
{
    internal class BookNotFoundException : Exception
    {
        public BookNotFoundException() : base("Book Does Not Exist!!") 
        { }
    }
}
