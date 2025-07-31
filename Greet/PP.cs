using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    public class PP
    {
        string name;

        public PP()
        {
            name = "Jane Doe";
        }
        public PP(string name)
        {
            this.name = name;
        }
        public void greet()
        {
            Console.WriteLine($"Good Night, {name}");
        }

    }
}
