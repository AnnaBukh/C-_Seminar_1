// Задача 2
// Напишите программу, которая на вход принимает два числа 
// и выдает какое число больше, а какое меньше 


Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
        if (a>b)
         Console.Write($"число {a} больше {b}");
        else if (a<b)
         Console.Write($"число {a} меньше {b}");
    else Console.Write("числа равны друг другу");
