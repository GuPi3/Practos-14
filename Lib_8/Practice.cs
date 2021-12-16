using System;

namespace Lib_8
{
    public class Practice
    {


        public static void CosOfSum(int[] inputArray, out double sum)
        {
            sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i]<3)
                {
                    sum += inputArray[i];
                }
            }
            sum = Math.Cos(sum);
        }
    }
}
