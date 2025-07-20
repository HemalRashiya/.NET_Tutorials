using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___Array
{
    internal class T10
    {
        public static void t10()
        {

                int rows, cols;

                Console.Write("Enter the number of rows: ");
                rows = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                cols = int.Parse(Console.ReadLine());

                
                int[,] matrix1 = new int[rows, cols];
                int[,] matrix2 = new int[rows, cols];
                int[,] sumMatrix = new int[rows, cols];

               
                Console.WriteLine("Enter elements for the first matrix:");
                InputMatrixElements(matrix1);

                
                Console.WriteLine("Enter elements for the second matrix:");
                InputMatrixElements(matrix2);

                // Add the matrices
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                // Display the sum matrix
                Console.WriteLine("Sum of the matrices:");
                DisplayMatrix(sumMatrix);
            }

            // Method to input elements into a matrix
            static void InputMatrixElements(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Element at row {i + 1}, column {j + 1}: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }

            // Method to display a matrix
            static void DisplayMatrix(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
}
