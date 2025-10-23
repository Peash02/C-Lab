using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    internal class SumOfDigit
    {
        int num;
        int sum = 0;
        int temp;
        public SumOfDigit(int num)
        {
            this.num = num;
        }
        public void process()
        {
            while (num > 0)
            {
                temp = num % 10;
                num /= 10;
                sum = sum + temp;
            }

        }
        public void display()
        {
            Console.WriteLine($"The Sum is {sum}");
        }
    }
}
