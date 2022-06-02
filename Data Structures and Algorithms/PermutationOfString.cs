using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class PermutationOfString
    {
        public static void permutation(String inputString, String answer)
        {
            if (inputString.Length == 0)
            {
                Console.Write(answer + "  ");
            }

            for (int i = 0; i < inputString.Length; i++)
            {
                char ch = inputString[i];
                String left_substr = inputString.Substring(0, i);
                String right_substr = inputString.Substring(i + 1);
                String rest = left_substr + right_substr;
                permutation(rest, answer + ch);
            }
        }
    }
}