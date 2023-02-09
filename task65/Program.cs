// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(numberN, numberM);

void NaturalNumbersRange(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) Console.Write($"{firstNumber} ");
    else if (firstNumber <= secondNumber)
    {
        Console.Write($"{firstNumber} ");
        NaturalNumbersRange(firstNumber + 1, secondNumber);
    }
    else
    {
        Console.Write($"{firstNumber} ");
        NaturalNumbersRange(firstNumber - 1, secondNumber);
    }
}
