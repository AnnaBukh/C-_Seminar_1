// напишите программу, которая принимает на вход 3 числа
// и выдает максимальное из этих чисел

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a)
    max = b;
if (c > max)
    max = c;

Console.Write($"максимальное число из трех {max}");

