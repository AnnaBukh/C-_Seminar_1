﻿// напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает последнюю цифру
//этого числа
//456->6

Console.Write("Введите 3-х значное число:");
int a = int.Parse(Console.ReadLine());

if (a < 0 )
{
    Console.WriteLine($"Последняя цифра введенного числа: {a * -1 % 10}");
}
else
{
    Console.WriteLine($"Последняя цифра введенного числа: {a % 10}");
}
