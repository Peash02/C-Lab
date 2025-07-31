using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public class Sqr
    {
        int num;
        int sqr;
        public Sqr()
        {
            num = 2;
        }
        public Sqr(int num)
        {
            this.num = num;
        }
        public void calc()
        {
            sqr = num * num;
        }
        public void display()
        {
            Console.WriteLine("The Square Of " + num + " is " +  sqr);
        }
    }
}
