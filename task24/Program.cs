//  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int number = int.Parse(Console.ReadLine()); - конвертирует только  тип данных Строка (string);

int sumnumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumnumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum = sum + i; //sum += i; - сокращенная запись строки 
    }
    return sum;
}