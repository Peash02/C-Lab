using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem.Exceptions
{
    internal class InvalidMarksException : Exception
    {
        public InvalidMarksException() : base("Invalid Marks!!!") { }
    }
}
