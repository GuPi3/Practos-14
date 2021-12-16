using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LibMas
{
    public class Matrixs
    {
        public static int[,] FillMatrix(int rowNumber, int columnNumber)
        {
            int[,] generatedMatrix = new int[columnNumber, rowNumber];
            Random randonNUmber = new Random();
            for (int i = 0; i < columnNumber; i++)
            {

                for (int j = 0; j < rowNumber; j++)
                {
                    generatedMatrix[i, j] = randonNUmber.Next(0, 50);

                }
            }
            return generatedMatrix;
        }
        public static void SaveMatrix1(int[,] matrix1)
        {
            using (StreamWriter save1 = new StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file.txt")))
            {
                save1.WriteLine(matrix1.GetLength(0));
                save1.WriteLine(matrix1.GetLength(1));
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {

                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        save1.WriteLine(matrix1[i, j]);
                    }
                }
            }
        }
        public static void OpenMatrix(out int[,] savedMatrix)
        {
            using (StreamReader open1 = new StreamReader(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file.txt")))
            {
                int arrayRows = Convert.ToInt32(open1.ReadLine());
                int arrayColumn = Convert.ToInt32(open1.ReadLine());
                savedMatrix = new int[arrayRows, arrayColumn];
                for (int i = 0; i < savedMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < savedMatrix.GetLength(1); j++)
                    {
                        savedMatrix[i, j] = Convert.ToInt32(open1.ReadLine());
                    }
                }
            }
        }
    }
}
