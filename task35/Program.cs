// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат вотрезке [10,99].

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int CountElement(int[] arr, int min = 10, int max = 99)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] >= min && arr[i] <= max)
            count++;
    return count;
}

int[] array = CreateArrayRndInt(8, -100, 99);
PrintArray(array);
int countElement = CountElement(array);
Console.WriteLine($"-> {countElement}");