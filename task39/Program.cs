// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]

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
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

// Array.Reverse(array); - встроенный метод для реверса

// void ReverseArray2(int[] arr) - реверс через цикл while
// {
//     int index1 = 0;
//     int index2 = arr.Length - 1;
//     while (index1 < index2)
//     {
//         int obj = arr[index1];
//         arr[index1] = arr[index2];
//         arr[index2] = obj;
//         index1++;
//         index2--;
//     }
// }

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);