// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; k < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
        }
            Console.Write($"{matrix[i, j]} \t");
    }
        Console.WriteLine();
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив: ");
inputMatrix(matrix);
int[,] matrixOrder = new int[coord[0], coord[1]];
for (int n = 0; n < matrixOrder.GetLength(0); n++)
    {
        for (int m = 0; m < matrixOrder.GetLength(1); m++)
        {
            matrixOrder[n, m] = matrix[n, m];
        }
    }
Console.WriteLine();
Console.WriteLine("Выровненный массив: ");
        for (int i = 0; i < matrix.GetLength(0); i++)
    {           
        for (int j = 0; j < matrix.GetLength(1); j++)
        { if (matrix[i,j] < matrix[i+1,j])
            {
             matrixOrder[i,j] = matrix[i+1,j];
             matrixOrder[i=1,j] = matrixOrder[i,j];
            }
        }
              
    }
        Console.WriteLine($"{matrixOrder}");