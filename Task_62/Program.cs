// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void InputMatrix(int[,] matrix)
{int count = 1;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
            matrix[i, j] = count++;
        }           
    }
    for (int j = matrix.GetLength(1); j < matrix.GetLength(1)+1; j++)
    { 
        for (int i = 0; i < matrix.GetLength(0); i++)
        { 
            matrix[i, j] = count++;
        }           
    }
    for (int i = 0; i < 1; i++)
    {
        for (int j = matrix.GetLength(1); j < 0; j--)
        { 
            matrix[i, j] = count++;
        }           
    }
    for (int j = 0; j < 1; j++)
    {
          for (int i = matrix.GetLength(0); i < 1; j--)
          { 
            matrix[i, j] = count++;
          }           
    }
    for (int i = 1; i < 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        { 
            matrix[i, j] = count++;
        }           
    }
    for (int j = matrix.GetLength(1)-1; j < matrix.GetLength(1); j++)
    {
          for (int i = 1; i < matrix.GetLength(0)-1; j++)
          { 
            matrix[i, j] = count++;
          }           
    }
    for (int i = matrix.GetLength(0)-1; i < matrix.GetLength(0); i++)
    {
        for (int j = matrix.GetLength(1)-1; j < matrix.GetLength(1); j++)
        { 
            matrix[i, j] = count++;
        }           
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
          {
            Console.Write($"{matrix[i, j]} \t");
            Console.WriteLine();
          }
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Полученный массив:");
PrintMatrix(matrix);