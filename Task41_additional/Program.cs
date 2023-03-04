// Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)). 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"

int count = 0;
string stop = "stop";
Console.WriteLine("Введите число:");
while (true)
{
    string userAnswer = Console.ReadLine()!;
    if(userAnswer.ToLower() == stop)
    {
        break;
    }
    int number = Convert.ToInt32(userAnswer);
    if(number > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел = {count}");