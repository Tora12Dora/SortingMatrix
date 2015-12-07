using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 55, 2, 3, 4, 5 };
            matrix[1] = new int[] { 4, 44, 5 };
            matrix[2] = new int[] { 1, 45, 3, 4, 5, 6, 7 };
            Console.WriteLine("Matrix sorted by SUM of elements:");
            PrintMatrix(BubbleSortMethod(matrix, SumOfElements));
            Console.WriteLine("Matrix sorted by MIN element:");
            PrintMatrix(BubbleSortMethod(matrix, MinElement));
            Console.WriteLine("Matrix sorted by MAX element:");
            PrintMatrix(BubbleSortMethod(matrix, MaxElement));
            Console.ReadKey();

        }

        private static void PrintMatrix(int[][] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {

                    Console.Write("{0} ", matrix[i][j]);
                }
                Console.WriteLine();
            }
        }


        private static int[][] BubbleSortMethod(int[][] matrix, Func<int[], int> methodI)
        {
            for (int i = matrix.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (methodI(matrix[j]) > methodI(matrix[j + 1]))
                    {
                        int[] m = matrix[j];
                        matrix[j] = matrix[j + 1];
                        matrix[j + 1] = m;
                    }
                }
            }
            return matrix;
        }

        public static int SumOfElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static int MinElement(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }

}
