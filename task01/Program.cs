// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет 

Console.WriteLine("Введите целое число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int square = b * b;

if (square == a)
{
    Console.WriteLine($"Число {a} является квадратом {b}");
}
else
{
    Console.WriteLine($"Число {a} не является квадратом {b}");
}