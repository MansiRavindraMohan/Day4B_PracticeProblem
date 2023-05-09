using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class ArrayCount
    {
        public void MethodArrayCount()
        {
            int[] arr = { 1, 2, 3, 4, 2, 5, 6, 7, 6, 8, 9, 9, 1 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements in the array: " + count);
        }
    }
}
