using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake
{
    public class Exercise2
    {
        public static string Run()
        {
            int[] input = { 1, 7, 3, 4 };
            int[] initProducts = new int[input.Length];
            int productsSoFar = 1;

            for (int i = 0; i < input.Length; i++)
            {
                initProducts[i] = productsSoFar;
                productsSoFar *= input[i];
            }

            productsSoFar = 1;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                initProducts[i] *= productsSoFar;
                productsSoFar *= input[i];
            }

            return string.Join(", ", initProducts);
        }
        public static string RunWithDivision()
        {
            int[] input = { 1, 7, 3, 4 };
            int total = 1;
            for (int i = 0; i < input.Length; i++)
            {
                total *= input[i];
            }

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = total / input[i];
            }

            return string.Join(", ", input);
        }
    }
}
