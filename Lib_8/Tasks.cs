using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_8
{
   public class Tasks
    {
        public static void MaxNumbersColumn(int[,] inputMatrix, out string MaxNumber)
        {
            MaxNumber = string.Empty;
            int[] MaxNumbers = new int[inputMatrix.GetLength(1)];
            int j = 0;
            for (int i = 0; i < inputMatrix.GetLength(1); i++)
            {
                MaxNumbers[i] = int.MinValue;
                for (j = 0; j < inputMatrix.GetLength(0); j++)
                {

                    if (MaxNumbers[i] < inputMatrix[j, i])
                    {
                        MaxNumbers[i] = inputMatrix[j, i];
                    }
                }
                MaxNumber += MaxNumbers[i].ToString() + " ";
            }

        }
    }
}
