using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class ReverseString
    {
        public void ReverseStringMethod()
        {
            string str = "Mansi Ravindra Mohan";
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }
    }
}
