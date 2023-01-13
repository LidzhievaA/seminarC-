// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberOfNumber = NumberOfNumber(number);
Console.WriteLine(numberOfNumber);

int NumberOfNumber(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num/10;
        count++;
    }
return count;
}