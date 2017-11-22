using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake
{
    public class Exercise3
    {
        public static string DoIt()
        {
            int[] input = { 1, 10, -5, 1, -100 };

            int highestProductOf2 =input[0] * input[1];
            int highest = Math.Max(input[0], input[1]);
            int lowestProductOf2 = input[0] * input[1];
            int lowest = Math.Min(input[0], input[1]);
            int highestProductOf3 = input[0] * input[1] * input[2];


            for (int i = 2; i < input.Length; i++)
            {
                highestProductOf3 = Math.Max(highestProductOf3, Math.Max(highestProductOf2 * input[i], lowestProductOf2 * input[i]));
                highestProductOf2 = Math.Max(highestProductOf2, highest * input[i]);
                lowestProductOf2 = Math.Min(lowestProductOf2, lowest * input[i]);

                highest = Math.Max(highest, input[0]);
                lowest = Math.Min(lowest, input[0]);
            }
            
            return highestProductOf3.ToString();
        }


        //public static string DoItForK()
        //{
        //    int[] input = { 1, 10, -5, 1, -100 };
        //    int varsCt = 3;
        //    int[] vars = new int[varsCt];

        //    for (int i =0; i < varsCt; i++)
        //    {
        //        vars[i]
        //    }
        //    int highest = Math.Max(input[0], input[1]);
        //    int lowest = Math.Min(input[0], input[1]);
        //    int highestProductOf2 = input[0] * input[1];
        //    int lowestProductOf2 = input[0] * input[1];
        //    int highestProductOf3 = input[0] * input[1] * input[2];


        //    for (int i = 2; i < input.Length; i++)
        //    {
        //        highestProductOf3 = Math.Max(highestProductOf3, Math.Max(highestProductOf2 * input[i], lowestProductOf2 * input[i]));
        //        highestProductOf2 = Math.Max(highestProductOf2, highest * input[i]);
        //        lowestProductOf2 = Math.Min(lowestProductOf2, lowest * input[i]);

        //        highest = Math.Max(highest, input[0]);
        //        lowest = Math.Min(lowest, input[0]);
        //    }

        //    return highestProductOf3.ToString();
        //}
    }
}
