// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Cлучайное число из отрезка 10-99: => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
    Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
else
    Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// 2 вариант написания программы ТЕРНАРНЫЙ :
Console.Write("Наибольшая цифра числа = ");
Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

// 2 вариант через новую переменную:
int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.Write($"Наибольшая цифра числа = {result}");


// 3. Создаем функцию (MaxDigit)
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int MaxDigit(int num)
{
   int firstDigit = num / 10;
   int secondDigit = num % 10;
   int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}