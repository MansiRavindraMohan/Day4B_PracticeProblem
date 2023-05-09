using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class MinMax
    {
        public void MinMaxMethod()
        {
            int[] arr = { 57, 28, 10, 35, 89, 94, 60, 25, 71 };

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Minimum element in the array is: " + min);
            Console.WriteLine("Maximum element in the array is: " + max);
        }
    }
}
