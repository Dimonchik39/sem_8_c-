// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] MatrixToArray(int[,] matr)
{
    int count = 0;
    int[] newArray = new int[matr.Length];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            newArray[count] = matr[i, j];
            count++;
        }
    }
    return newArray;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.Write("]");
}

void ShowCount(int[] arr)
{
int num = arr[0];
int count = 1;
for (int i = 1; i < arr.Length; i++)
{
if (arr[i] == num) count++;
else
{
Console.WriteLine($"{num} содержится {count} раз. ");
num = arr[i];
count = 1;
}
if (i == arr.Length-1) Console.WriteLine($"{num} содержится {count} раз.");
}
}

int[,] matrix = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
ShowCount(array);

