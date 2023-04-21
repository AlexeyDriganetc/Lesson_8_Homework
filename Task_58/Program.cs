// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [0; 10];
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void СompositionElements(int[,] matrix, int[,] matrix2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = matrix[i,j] * matrix2[i,j];          
        }
    } 
}


Console.Clear();
Console.Write("Введите размеры массивов: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Массив 1");
PrintMatrix(matrix);
InputMatrix(matrix2);
Console.WriteLine("Массив 2");
PrintMatrix(matrix2);
СompositionElements(matrix,matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
PrintMatrix(matrix);