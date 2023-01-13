// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number <= 0)
// Console.WriteLine("");

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");

int Factorial(int num)
{
    int factorialNumber = 1;
    for(int i = 1; i <= num; i++)
    {checked // - проверка переполнения результата
    {
         // factorialNumber *= i; 
        factorialNumber=  factorialNumber * i; 
    }
    }
   
    return factorialNumber;
}