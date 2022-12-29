// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
string quarter = Console.ReadLine();

string result = QuarterCoordinates(quarter);
Console.WriteLine(result);


// int quarter = Quarter(x, y);
// string result = quarter > 0
//                 ? $"указанные координаты соответствуют четверти {quarter}"
//                 : "Введены некорректные координаты";
// Console.WriteLine(result);

string QuarterCoordinates(string quarterNumber)
{
    if (quarterNumber == "1") return "x > 0 и y > 0";
    if (quarterNumber == "2") return "x < 0 и y > 0";
    if (quarterNumber == "3") return "x < 0 и y < 0";
    if (quarterNumber == "4") return "x > 0 и y < 0";
    return "Некорректные данные";
}


// {
//     if (xc > 0 && y > 0) return 1;
//     if (xc < 0 && y > 0) return 2;
//     if (xc < 0 && y < 0) return 3;
//     if (xc > 0 && y < 0) return 4;
//     return 0;
// }