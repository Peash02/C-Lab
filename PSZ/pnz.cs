using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSZ
{
    public class pnz
    {
        int num;

        public pnz()
        {
            num = 2;
        }
        public pnz(int num)
        {
            this.num = num;
        }
        public void check()
        {
            if (num ==0)
            {
                Console.WriteLine("The Number is Zero.");
            }
            else if (num > 0)
            {
                Console.WriteLine("The Number is Positive.");
            }
            else
            {
                Console.WriteLine("The Number is Negative.");
            }
        }
    }
}
