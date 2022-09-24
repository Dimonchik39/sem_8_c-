// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

int[,] ChangePlace(int[,] arr)
{
int[,] arrResult = new int[arr.GetLength(0), arr.GetLength(1)];
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arrResult[i, j] = arr[j, i];
}
}
return arrResult;
}

bool CheckSq(int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}

int[,] matrix = CreateMatrixRndInt(5, 5, 1, 99);
PrintMatrix(matrix);
Console.WriteLine();

if (CheckSq(matrix))
{
    int[,] array = ChangePlace(matrix);
    PrintMatrix(array);
}
else Console.WriteLine("Количество строк должно совпадать с количеством столбцов");


