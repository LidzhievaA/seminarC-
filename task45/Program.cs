// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("]");
}

int[] arrayOrigin = CreateArrayRndInt(8, -10, 10);
PrintArray(arrayOrigin);

int[] arrayCopy = CopyArray(arrayOrigin);
PrintArray(arrayCopy);