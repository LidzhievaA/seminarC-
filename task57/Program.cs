// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[] MatrixToArray (int [,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i,j];
            k++;
        }
    }
    return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void UniqElemQuantity (int[] arr)
{
    int number = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} -> {count}");
            number = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{number} -> {count}");
}


int[,] array2D = CreateMatrixRndInt(5, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = MatrixToArray(array2D);
PrintArray(array);
Console.WriteLine();

Array.Sort(array);
PrintArray(array);

Console.WriteLine();
UniqElemQuantity(array);