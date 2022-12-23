// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int resultNumber = number1%number2;
if (resultNumber ==0) 
    Console.WriteLine("Кратно");
else 
    Console.WriteLine($"Не кратно, остаток {resultNumber}");

// bool resultNumber = number1%number2 == 0;
// if (resultNumber) 
//     Console.WriteLine("Кратно");
// else 
//     Console.WriteLine($"Не кратно, остаток {number1%number2}");


// Через метод:
// int Multiplcity(int numOne, numTwo)
//      return numOne%numTwo;

//int result = Multiplcity(int numOne, numTwo);
//Console.WriteLine(result==0 ? "Кратно" : $"Не кратно, остаток {result}");