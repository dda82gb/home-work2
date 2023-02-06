// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine ("Введите пятизначное число: ");
string num = Console.ReadLine();
int pal = num.Length;

if (pal == 5)
{
    if (num[0] == num[4] && num [1] == num[3])
    {
         Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(num + " --> Палиндром");
    }

    else
    {
         Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(num + " --> Не палиндром");
    }
}
else
{
     Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ($"Вы ввели НЕ ПЯТИЗНАЧНОЕ число.");
    Console.WriteLine($"Введи правильное число !");
}

