using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class UniqueElement
    {
        public void UniqueElementMethod()
        {
            int[] arr = { 10, 20, 30, 40, 20, 50, 60, 70, 60, 80, 90, 90, 10 };
            Console.WriteLine("The unique elements in the array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                bool unique = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
