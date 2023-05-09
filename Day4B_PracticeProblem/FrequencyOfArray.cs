using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class FrequencyOfArray
    {
        public void MethodFrequency()
        {
            string[] arr = { "M","A", "N", "S", "I", "M", "O", "H", "A", "N" };
            int[] frequency = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        frequency[j] = -1;
                    }
                }

                if (frequency[i] != -1)
                {
                    frequency[i] = count;
                }
            }

            Console.WriteLine("Frequency of each element in the array: ");

            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] != -1)
                {
                    Console.WriteLine(arr[i] + ":" + frequency[i] + " times");
                }
            }

        }
    }
}
