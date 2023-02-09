// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

Console.WriteLine("Введите число A: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B: ");
int inputDegree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(MathPow(inputNumber, inputDegree));

int MathPow(int num, int degree)
{
    if (degree == 0) return 0;
    else return num * MathPow(num, degree - 1);
}