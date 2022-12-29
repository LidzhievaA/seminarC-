﻿// // Math.Pow(2, 2); - возведение в степень (здесь 2 в степени 2)
// double d = Math.Sqrt(355); - извлечение квадратного корня

// double num = 5.099873456;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero); - округление числа num до 2 чисел после запятой, 
// Console.WriteLine(numRound);

// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки: ");
Console.Write("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa,xb,ya,yb),2, MidpointRounding.ToZero);
Console.WriteLine($"A ({xa},{xb}); B ({ya}, {yb}) -> {ourDistance}"); 

double Distance(int x1,int x2,int y1,int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
    return distance;
}