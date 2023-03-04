// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Например, если: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = ReadNumber("Введите значение b1");
double k1 = ReadNumber("Введите значение k1");
double b2 = ReadNumber("Введите значение b2");
double k2 = ReadNumber("Введите значение k2");

double pointX = (b2 - b1) / (k1 - k2);
double pointY = k1 * ((b2 - b1) / (k1 - k2)) + b1;

// int[] GetArray()
// {
//     int[] array = new int[number]
// }

// (int, int) PointLocation()
// {
//     int pointX = 0;
//     int pointY = 0;

// }

Console.WriteLine($"Точка пересечения прямях: {pointX}, {pointY}");