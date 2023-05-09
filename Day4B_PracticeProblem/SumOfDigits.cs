using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class SumOfDigits
    {
        public void DigitMethod()
        {
            int num = 123456789;
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
